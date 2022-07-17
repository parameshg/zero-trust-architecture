@echo off
cls
:loop
curl http://localhost:8080/fibonacci?count=20
printf "\n"
sleep 2
goto loop