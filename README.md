# Dapr Demo

Following the [Dapr getting started](https://docs.dapr.io/getting-started/) guide.

## Topology

```mermaid
graph LR
  A[Caller] -->|Http request| B("jsonplaceholder.typicode.com")
```

## Start application

```bash
dapr run ./dapr.yaml.
```

This will start the applications using the [Dapr multi app mode](./dapr.yaml).

## Builds

[![.NET](https://github.com/fredrkl/dapr-demo/actions/workflows/dotnet.yml/badge.svg)](https://github.com/fredrkl/dapr-demo/actions/workflows/dotnet.yml)
