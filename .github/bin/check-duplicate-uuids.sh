#!/bin/bash

duplicate_uuids=$(find . -name config.json -exec jq -r '.[].uuid' {} \; | sort | uniq -d)

if [ ! -z "${duplicate_uuids}" ] ; then
    echo "Duplicate UUIDs were found in the config.json files:"
    echo "${duplicate_uuids}"
    exit 1
fi
