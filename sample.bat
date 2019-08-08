@echo off
cls

iwm_MsgBox.exe
echo %errorlevel%

iwm_MsgBox.exe -size=320,240 -title="ƒ^ƒCƒgƒ‹" -message="‚ ‚ ‚ \\‚ ‚ ^\t‚¢‚¢\‚¢‚¢‚¢^\n^\n^\n‚¤‚¤‚¤‚¤‚¤" -button=1,1
echo %errorlevel%

echo.
pause
exit
