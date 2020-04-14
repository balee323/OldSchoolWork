rem @echo off

set Script=test1.txt
set LawsonFolder=C:/test/Lawson/
set DownLoadFolder=C:/test/downloadFolder/

set LogFile=log.txt

call echo.open 192.10.20.101>test1.txt
call echo.Login>>%Script%
call echo.password>>%Script%
call echo.lcd %DownloadFolder%>>%Script%
call echo.prompt>>%Script%
call echo.ls %LawsonFolder%/ap_2x3_*.*>>%Script%
call echo.mget %LawsonFolder%/ap_2x3_*.*>>%Script%
call echo.mdel %LawsonFolder%/ap_2x3_*.*>>%Script%
call echo.bye>>%Script%


echo.Ftp script for %Script%>>%LogFile%
echo.=====================================================>>%LogFile%
type %Script%>>%LogFile%
echo.>>%LogFile%

