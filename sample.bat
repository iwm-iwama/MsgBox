@echo off
cls

::---------
:: �w���v
::---------
for /f "usebackq delims=" %%s in (`"iwm_MsgBox.exe"`) do echo %%s

::-------------
:: �P�s�ŋL�q
::-------------
for /f "usebackq delims=" %%s in (`"iwm_MsgBox.exe -size=250,160 -title="�P�s�ŋL�q" -text="�I�v�V������\\n�P�s�ŋL�q������" -textsize=10 -checkbox="��L���e���������܂��B" -button=1,1 -buttontext="�͂�","������","����""`) do echo %%s

::---------------------
:: �ϐ����p�ɂ��L�q
::---------------------
set SIZE=250,160
set TITLE=�ϐ����p�ɂ��L�q
set TEXT= ^
�I�v�V������\\n ^
�ϐ��𗘗p���ċL�q������
set TEXTSIZE=10
set CHECKBOX=��L���e���������܂��B
set BUTTON=1,1
set BUTTONTEXT="�͂�","������","����"

for /f "usebackq delims=" %%s in (`"iwm_MsgBox.exe -size=%SIZE% -title="%TITLE%" -text="%TEXT%" -textsize=%TEXTSIZE% -checkbox="%CHECKBOX%" -button=%BUTTON% -buttontext=%BUTTONTEXT%"`) do echo %%s

echo.
pause
exit
