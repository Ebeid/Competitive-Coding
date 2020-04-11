#!/bin/bash
mkdir solutions
cd solutions
for i in $(seq -f "%04g" 1 1500)
do
  echo "Creating directory $i "
  mkdir -p $i
  cd $i
  echo "Solution for problem $i" > README.md
  eval "dotnet new console"
  cd ..
done