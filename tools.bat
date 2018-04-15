@echo off
set arg1=%1

if "%arg1%"=="" (set brand="gold_master") else (set brand=%1"_master")

cd Assets\Base_UI
git reset --hard HEAD
git checkout %brand%

cd ..\Lobby_UI
git reset --hard HEAD
git checkout %brand%

cd ..\..

echo 切换到%brand%成功！