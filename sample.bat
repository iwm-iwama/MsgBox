@echo off
cls

iwm_MsgBox.exe
echo %errorlevel%

iwm_MsgBox.exe -title="ƒ^ƒCƒgƒ‹" -text="‚ ‚ ‚ \\‚ ‚ ^\t‚¢‚¢\‚¢‚¢‚¢^\n^\n^\n‚¤‚¤‚¤‚¤‚¤" -size=400,160 -textsize=20 -button=1,1 -button2="Yes","No","Cancel"
echo %errorlevel%

echo.
pause
exit
