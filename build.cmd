@echo off
pushd Client
dotnet publish -c Release
popd

pushd Server
dotnet publish -c Release
popd

rmdir /s /q dist
mkdir dist

copy /y fxmanifest.lua dist
xcopy /y /e Client\bin\Release\net452\publish dist\Client\bin\Release\net452\publish\
xcopy /y /e Server\bin\Release\net462\publish dist\Server\bin\Release\net462\publish\