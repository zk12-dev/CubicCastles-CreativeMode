@echo off
setlocal enabledelayedexpansion

:: Loop through all PNG files in the current directory ending with "_cropped.png"
for %%f in (*_cropped.png) do (
    set "filename=%%~nf"  :: Get the filename without extension
    set "ext=%%~xf"       :: Get the file extension

    :: Remove "_cropped" from the filename
    set "newname=!filename:_cropped=!"

    :: Remove only the first two leading zeros
    if "!newname:~0,1!"=="0" set "newname=!newname:~1!"
    if "!newname:~0,1!"=="0" set "newname=!newname:~1!"

    :: Prepare the final new filename
    set "finalname=!newname!!ext!"

    :: Display what is being renamed for debugging
    echo Renaming "%%f" to "!finalname!"

    :: Rename the file
    ren "%%f" "!finalname!"
)

endlocal
pause
