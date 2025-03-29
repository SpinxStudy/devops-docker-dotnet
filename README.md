# PaymentGateway API - Docker Use
Basic usage from container docker with a .NET API

## Creating container
```
docker build -t dev-paymentgatewayapi:latest .
```

## Run docker
```
docker run -d -p 5000:8080 --name dev-paymentgatewayapi-container dev-paymentgatewayapi:latest
```

## Check the container
```
docker ps
```

## Publishing docker image
```
docker tag dev-paymentgatewayapi wladylinux/dev-paymentgatewayapi:latest
docker push wladylinux/dev-paymentgatewayapi:latest
```