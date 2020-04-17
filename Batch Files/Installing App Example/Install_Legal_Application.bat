@ECHO OFF


rem not everyone has access to this path -> SET REMOTEPATH=\\nasdata\depts\TECHDEV\HomeOfficeApps\Legal_App\ 
SET REMOTEPATH=\\nasdata\depts\HOMEOFF\Install_Legal_on_Windows_7\
SET WINPATH=C:\Legal_App\

rem ********** Create Legal Dir
rem IF NOT EXIST %WINPATH% MKDIR %WINPATH%
IF EXIST %WINPATH% Del %WINPATH%*.* /Q
IF EXIST %WINPATH% RMDIR %WINPATH% /Q


IF NOT EXIST %WINPATH% MKDIR %WINPATH%



REM ********** Register Dlls and OCXs

REM **** 1
SET OCX=CRVIEWER.DLL
IF NOT EXIST %WINPATH%%OCX% COPY %REMOTEPATH%%OCX% %WINPATH%%OCX%
IF EXIST C:\Windows\system32\%OCX% Msg * %OCX% already registered
IF NOT EXIST %WINPATH%%OCX% c:\windows\system32\regsvr32.exe  /s %WINPATH%%OCX%



REM **** 2
SET OCX=CCRPDTP.OCX
IF NOT EXIST %WINPATH%%OCX% COPY %REMOTEPATH%%OCX% %WINPATH%%OCX%
IF EXIST C:\Windows\system32\%OCX% Msg * %OCX% already registered
IF NOT EXIST C:\Windows\system32\%OCX% c:\windows\system32\regsvr32.exe /s %WINPATH%%OCX%


REM **** 3
SET OCX=MSVBVM50.DLL
IF NOT EXIST C:\Windows\system32\%OCX% COPY %REMOTEPATH%%OCX% %WINPATH%%OCX%
IF EXIST C:\Windows\system32\%OCX% Msg * %OCX% already registered
IF NOT EXIST C:\Windows\system32\%OCX% c:\windows\system32\regsvr32.exe /s %WINPATH%%OCX%


REM **** 4
SET OCX=MSMASK32.OCX
IF NOT EXIST %WINPATH%%OCX% COPY %REMOTEPATH%%OCX% %WINPATH%%OCX%
IF EXIST C:\Windows\system32\%OCX% Msg * %OCX% already registered
IF NOT EXIST C:\Windows\system32\%OCX% c:\windows\system32\regsvr32.exe /s %WINPATH%%OCX%


REM **** 5
SET OCX=comctl32.ocx
IF NOT EXIST C:\Windows\system32\%OCX% COPY %REMOTEPATH%%OCX% %WINPATH%%OCX%
IF EXIST C:\Windows\system32\%OCX% Msg * %OCX% already registered
IF NOT EXIST C:\Windows\system32\%OCX% c:\windows\system32\regsvr32.exe /s %WINPATH%%OCX%



REM **** Copy Legal EXE and shortcut

SET exe=Legal.EXE
IF NOT EXIST %WINPATH%%exe% COPY %REMOTEPATH%%exe% %WINPATH%%exe%

rem SET vbsScript=shortcut_helper.vbs
rem IF NOT EXIST %WINPATH%%vbsScript% COPY %REMOTEPATH%%vbsScript% %WINPATH%%vbsScript%









rem echo mklink "%userprofile%\Desktop\"%WINPATH%%exe%
rem echo mklink "%userprofile%\Desktop\" %WINPATH%%exe%

rem - puts shortcut in Legal_App directory

call %REMOTEPATH%Shortcut_helper /target:"C:\legal_app\legal.exe" /shortcut:%WINPATH%"Legal_test"

REM ****  Put Shortcut on Desktop
xcopy C:\Legal_App\*.lnk "C:\Documents and Settings\%USERNAME%\Desktop" /F /Y
xcopy C:\Legal_App\*.lnk "C:\Users\All Users\Desktop" /F /Y
xcopy C:\Legal_App\*.lnk "C:\Documents and Settings\All Users\Desktop" /F /Y



Msg * Complete



rem PAUSE 