#!/usr/bin/env bash
# Syncs this checkout to origin/main and redeploys the compose stack.
# Run on the server by the natrix-deploy systemd timer every 5 minutes.
set -euo pipefail

main() {
  cd "$(dirname "$0")/.."

  git fetch --quiet origin main
  # Discards any local edits: the server checkout always matches main.
  git reset --hard --quiet origin/main

  cd infra
  docker compose -p natrix pull --quiet
  docker compose -p natrix up -d --remove-orphans
  docker image prune -f
}

# The reset above can rewrite this file while it runs. Bash parses the whole
# function before calling it, and the exit stops it reading past this line.
main "$@"
exit
