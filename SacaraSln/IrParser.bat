.\packages\FsLexYacc\build\fslex.exe "ES.Sacara.Ir.Parser\SacaraIrLexer.fsl" --unicode -o "ES.Sacara.Ir.Parser\SacaraIrLexer.fs"
.\packages\FsLexYacc\build\fsyacc.exe "ES.Sacara.Ir.Parser\SacaraIrParser.fsy" --module ES.Sacara.Ir.Parser.SacaraIrParser -o "ES.Sacara.Ir.Parser\SacaraIrParser.fs"