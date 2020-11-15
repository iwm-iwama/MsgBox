@echo off
cls

iwm_MsgBox.exe
echo %errorlevel%

iwm_MsgBox.exe -size=250,160 -title="タイトル" -text="あいうえお^\nかき^\tくけこ" -textsize=10 -checkbox="上記内容を承諾します。" -button=1,1 -buttontext="はい","いいえ","閉じる"
echo %errorlevel%

echo.
pause
exit
