
@echo  off
setlocal

IF  not exist "ViewCs\Lang"  mkdir "ViewCs\Lang"
IF  not exist "ViewVb\Lang"  mkdir "ViewVb\Lang"

resgen  ^
    ViewCs\Lang\Strings.resx    ^
    ViewCs\Lang\ViewCs.Lang.Strings.resources   ^
    /str:c#,ViewCs.Lang,Strings,ViewCs\Lang\Strings.Designer.cs     ^
    /publicClass

IF %errorlevel% neq 0 (
    echo [ERROR] resgen ViewCs
    EXIT  /b 1
)


resgen  ^
    ViewVb\Lang\Strings.resx    ^
    ViewVb\Lang\ViewVb.Lang.Strings.resources   ^
    /str:vb,My.Resources,Strings,ViewVb\Lang\Strings.Designer.vb    ^
    /publicClass

IF %errorlevel% neq 0 (
    echo [ERROR] resgen ViewVb
    EXIT  /b 2
)

echo [SUCCESS] resgen

endlocal
EXIT  /b 0
