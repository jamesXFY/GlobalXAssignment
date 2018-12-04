@echo off
set arg1=%1
set arg2=%~dp0
@echo on
.\ConsoleApplication6\bin\Debug\ConsoleApplication6.exe %arg1% "%arg2%"

pause