docker build --no-cache -f SQL\Dockerfile.PostgreSql -t uchetmedosmotrov2-java/postgre-sql ../../SQL

docker build --no-cache -f Dockerfile -t uchetmedosmotrov2-java/app ../../..
