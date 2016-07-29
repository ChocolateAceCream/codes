echo Please Insert the computer name (e.g. \\chh001):
set /p Computer=
echo Please Insert your username (e.g. chh\jsmith):
set /p Username=
echo Please Insert your Password:
set /p Password=

\\chhws1\Installs\installer_script\psexec.exe %Computer% -u "%Username%" -p "%Password%" cmd /c mkdir c:\install


:: Install Office 2010
\\chhws1\Installs\installer_script\psexec.exe %Computer% -h -u "%Username%" -p "%Password%" cmd /c "\\chhws1\Installs\MSO2K10ST\setup.exe" /config \\chhws1\Installs\MSO2K10ST\Standard.WW\config.xml