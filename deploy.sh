#! /usr/bin/env bash

BUILD_DIR="./dist";

if [ ! -d ${BUILD_DIR} ]; then
  echo "Creating build directory.";
  mkdir -p ${BUILD_DIR};
fi

/usr/bin/dotnet publish -c Release -r linux-x64 -o ${BUILD_DIR} --no-self-contained; 

