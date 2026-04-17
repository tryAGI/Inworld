#!/usr/bin/env bash
set -euo pipefail

# Inworld has no public OpenAPI spec, so openapi.yaml is handcrafted from
# https://docs.inworld.ai/api-reference/* and https://docs.inworld.ai/llms.txt.
#
# Auth: Inworld expects `Authorization: Basic <API_KEY>` where <API_KEY> is
# already Base64-encoded by the Inworld Portal. We generate with
# `Http:Header:Bearer` and rewrite the scheme from `Bearer` to `Basic` at
# runtime via an Authorized partial hook (see Extensions/InworldClient.Auth.cs).

dotnet tool install --global autosdk.cli --prerelease

rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Inworld \
  --clientClassName InworldClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
