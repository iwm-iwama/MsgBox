@echo off
cls

for /f "usebackq delims=" %%s in (`"iwm_MsgBox.exe"`) do echo %%s

for /f "usebackq delims=" %%s in (`"iwm_MsgBox.exe -size=250,160 -title="�^�C�g��" -text="����������\\n����\\t������" -textsize=10 -checkbox="��L���e���������܂��B" -button=1,1 -buttontext="�͂�","������","����""`) do echo %%s

echo.
pause
exit
