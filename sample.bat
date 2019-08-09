@echo off
cls

iwm_MsgBox.exe
echo %errorlevel%

iwm_MsgBox.exe -title="ƒ^ƒCƒgƒ‹" -text="‚ ‚ ‚ \\‚ ‚ ^\t‚¢‚¢\‚¢‚¢‚¢^\n^\n^\n‚¤‚¤‚¤‚¤‚¤" -button=1,1
echo %errorlevel%

echo.
pause
exit
