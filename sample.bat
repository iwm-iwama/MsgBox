@echo off
cls

for /f "usebackq delims=" %%s in (`"iwm_MsgBox.exe"`) do echo %%s

for /f "usebackq delims=" %%s in (`"iwm_MsgBox.exe -size=250,160 -title="タイトル" -text="あいうえお\\nかき\\tくけこ" -textsize=10 -checkbox="上記内容を承諾します。" -button=1,1 -buttontext="はい","いいえ","閉じる""`) do echo %%s

echo.
pause
exit
