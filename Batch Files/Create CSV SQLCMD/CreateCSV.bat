@echo off


echo let's make some CSVs...

set /p Server=Enter Server Name:
set /p DB=Enter Database Name:
set /p table=Enter Table Name:
set /p rows=Enter rows to return or enter for all:    
set /p orderby=Enter order by fields (field1, field2) or enter for none:
    
set /p name=Enter CSV file name:

 
if ["%rows%"] == [] (set rows=TOP 100 PERCENT)

if NOT ["x%rows%"] == ["x"] (set rows=TOP %rows%)

rem set orderby=order by storeNumber


if ["%orderby%"] == [] (set orderby=[])

if NOT ["x%orderby%"] == ["x"] (set orderby=order by %orderby%)



sqlcmd -S %Server% -d %DB% -E -Q "select %rows% * from %table% %orderby%" -o "%name%.csv" -s","


timeout /t -1