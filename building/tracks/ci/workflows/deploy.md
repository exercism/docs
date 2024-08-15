# Deploy workflow

The deploy workflow is used to deploy [track tooling](/docs/building/tooling) to:

1. [Docker Hub](https://hub.docker.com/): used in scripts or for local testing.
   Publicly available.
2. [ECR](https://aws.amazon.com/ecr/): used in the production environment to test submitted solutions.
   Private.

## Source

The workflow is defined in the `.github/workflows/deploy.yml` file.
