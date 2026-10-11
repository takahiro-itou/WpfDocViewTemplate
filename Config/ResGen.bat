
@echo  off
setlocal

IF  not exist "ViewCs\Lang"  mkdir "ViewCs\Lang"
IF  not exist "ViewVb\Lang"  mkdir "ViewVb\Lang"

resgen  ^
    ViewCs\Lang\Strings.resx            ^
    ViewCs\Lang\Strings.Designer.cs     ^
    /str:csharp,ViewCs.Lang,Strings,ViewCs\Lang\Strings.Designer.cs     ^
    /publicClass

IF %errorlevel% neq 0 (
    echo [ERROR] resgen (ViewCs).
    EXIT  /b 1
)


resgen  ^
    ViewVb\Lang\Strings.resx            ^
    ViewVb\Lang\Strings.Designer.vb     ^
    /str:vb,ViewVb.Lang,Strings,ViewVb\Lang\Strings.Designer.vb     ^
    /publicClass

IF %errorlevel% neq 0 (
    echo [ERROR] resgen (ViewVb)
    EXIT  /b 1
)

echo [SUCCESS] resgen

endlocal
EXIT  /b 0
