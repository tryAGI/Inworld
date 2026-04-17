#!/usr/bin/env bash
set -euo pipefail

# Inworld has no public OpenAPI/AsyncAPI spec, so both `openapi.yaml` and
# `asyncapi.yaml` are handcrafted from the published docs:
#   - https://docs.inworld.ai/api-reference/*  (REST)
#   - WebSocket synthesize/transcribe stream reference pages (Realtime)
#   - https://docs.inworld.ai/llms.txt  (index)
#
# Auth: Inworld expects `Authorization: Basic <API_KEY>` where <API_KEY> is
# already Base64-encoded by the Inworld Portal. We generate with
# `Http:Header:Bearer` and rewrite the scheme to `Basic` per request via the
# sub-client `PrepareRequest` hooks in Extensions/InworldClient.Auth.cs.
# JWT Bearer is also supported transparently: JWTs start with `eyJ` which the
# hook leaves untouched (see Extensions/InworldClient.Auth.cs).

dotnet tool install --global autosdk.cli --prerelease

rm -rf Generated

# -----------------------------------------------------------------------------
# REST API (OpenAPI) → main `Inworld` namespace
# -----------------------------------------------------------------------------
autosdk generate openapi.yaml \
  --namespace Inworld \
  --clientClassName InworldClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

# -----------------------------------------------------------------------------
# Realtime API (AsyncAPI) → `Inworld.Realtime` namespace.
# Cross-namespace schema referencing is not used here because the AsyncAPI
# messages use a top-level-key discriminator instead of the shared REST
# model shapes.
# -----------------------------------------------------------------------------
autosdk generate asyncapi.yaml \
  --namespace Inworld.Realtime \
  --websocket-class-name InworldRealtimeClient \
  --json-serializer-context RealtimeSourceGenerationContext \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer
