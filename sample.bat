@echo off
cls

iwm_MsgBox.exe
echo %errorlevel%

iwm_MsgBox.exe -size=250,160 -title="�^�C�g��" -text="����������^\n����^\t������" -textsize=10 -checkbox="��L���e���������܂��B" -button=1,1 -buttontext="�͂�","������","����"
echo %errorlevel%

echo.
pause
exit
