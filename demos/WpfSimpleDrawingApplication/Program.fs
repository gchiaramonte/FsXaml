﻿open System
open FsXaml

type App = XAML<"App.xaml">

[<STAThread>]
[<EntryPoint>]
let main argv = 
    Wpf.installBlendSupport ()
    App().Run ()
