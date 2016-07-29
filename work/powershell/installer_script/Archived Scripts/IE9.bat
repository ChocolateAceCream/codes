echo Please Insert the computer name (e.g. \\chh001):
set /p Computer=

echo Please Insert your Domain Admin Account username (e.g. chh\jsmith):
set /p Username=

echo Please Insert your Domain Admin Account Password:
set /p Password=

\\chhws1\Installs\installer_script\psexec.exe %Computer% -h -u "%Username%" -p "%Password%" cmd /c \\chhws1\installs\drivers\IE9-Windows7-x64-enu.exe /quiet /norestart /update-no
