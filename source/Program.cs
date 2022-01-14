
WriteLine ("Cleaner C# Code durch Fluent API\nvon Tom Schröter\n");

//-----------------------------------------------------------------------------
WriteLine ("Calculus:");

WriteLine
(
    Calculus
    .assign   (2.0D)
    .square
    .root
    .add      (4.0D)
    .multiply (6.0D)
    .operate  (Math.Sqrt)
    .operate  (Math.Pow , 2.0D)
    // .operate  (Math.Sin)
    .value
);
//-----------------------------------------------------------------------------
string name = "Donald Duck";

while ( !name.IsValid() )
{
    WriteLine ("Geben Sie bitte einen gültigen Namen ein:");
    name = ReadLine ();
}

WriteLine ($"Hallo {name}\n");

//-----------------------------------------------------------------------------
WriteLine ("Beispiele für Fluent Functional Extension:\n\n1. String.Split");

const StringSplitOptions SPLITOPTIONS =
      StringSplitOptions.None
    | StringSplitOptions.RemoveEmptyEntries
    | StringSplitOptions.TrimEntries
    ;

"Cleaner C# Code With Fluent API"
.Split (' ', SPLITOPTIONS)
.each  (word => WriteLine (word) )
;
//-----------------------------------------------------------------------------
WriteLine ("\n2. Reflection");

typeof      (Calculus)
.GetMembers ()
.each       (member => WriteLine (member))
;
//-----------------------------------------------------------------------------
WriteLine ($"\r\nOK @ {DateTime.Now}");
