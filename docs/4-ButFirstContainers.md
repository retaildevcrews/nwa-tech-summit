# 4 - But First, Containers

Containers have been adopted as a great way to alleviate portability issues. They form the core of this workshop and underpin everything you'll be exploring as you progress through the challenges.

The objective of this challenge is to ensure you understand the very basics of containers, can work with them on a build server (or locally).

## Challenge

- You've been tasked with improving the local development experience for new developers by using Docker to simplify the building, testing, and running of the application. Some of the work has been done for you, but it was during a time when teams were split between operations and development, leaving the code split between multiple codebases.

### Building and Testing

- Your first challenge is to verify that the application still works. In order to do this, you will need to build and run the application and build the docker image.
- Run the unit tests
- To build the application, use the [Helium Repo](https://github.com/retaildevcrews/helium-csharp) and [Dockerfile](https://docs.docker.com/engine/reference/builder/).

## Success Criteria

- Your team must show your coach a running Helium application on the build server as well as a Docker image. Verify that your app is serving content via HTTP. Explain your setup to your coach and how it could be used for development and testing.
- Extra credit - run the integration test

## References

- Docker
  - [Helium Repository](https://github.com/retaildevcrews/helium-csharp)
  - [Quick Start](https://github.com/retaildevcrews/aks-quickstart/blob/master/docker.md)
  - [Getting Started with Docker](https://docs.docker.com/get-started/)
  - [Docker Networking](https://docs.docker.com/v17.09/engine/userguide/networking)
  - [Dockerfile reference](https://docs.docker.com/engine/reference/builder/)
  - [Docker CLI reference](https://docs.docker.com/engine/reference/commandline/cli/)