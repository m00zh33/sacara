// Implementation file for parser generated by fsyacc
module ES.Sacara.Ir.Parser.SacaraIrParser
#nowarn "64";; // turn off warnings that type variables used in production annotations are instantiated to concrete type
open Microsoft.FSharp.Text.Lexing
open Microsoft.FSharp.Text.Parsing.ParseHelpers
# 1 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"


open System
open ES.Sacara.Ir.Parser.IrAst
open ES.Sacara.Ir.Parser.IrParserUtility


# 14 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
// This type is the type of tokens accepted by the parser
type token = 
  | INTEGER of (int32)
  | LABEL of (string)
  | IDENTIFIER of (string)
  | STRING of (string)
  | BOOLEAN of (bool)
  | CMP
  | GETSP
  | SWRITE
  | SREAD
  | BYTE
  | WORD
  | DWORD
  | NEWLINE
  | COMMA
  | EOF
  | GETIP
  | RET
  | JUMP
  | JUMPIFL
  | JUMPIFLE
  | JUMPIFG
  | JUMPIFGE
  | ALLOCA
  | HALT
  | PROC
  | ENDP
  | PUSH
  | POP
  | ADD
  | NOP
  | CALL
  | NCALL
  | WRITE
  | NWRITE
  | READ
  | NREAD
// This type is used to give symbolic names to token indexes, useful for error messages
type tokenId = 
    | TOKEN_INTEGER
    | TOKEN_LABEL
    | TOKEN_IDENTIFIER
    | TOKEN_STRING
    | TOKEN_BOOLEAN
    | TOKEN_CMP
    | TOKEN_GETSP
    | TOKEN_SWRITE
    | TOKEN_SREAD
    | TOKEN_BYTE
    | TOKEN_WORD
    | TOKEN_DWORD
    | TOKEN_NEWLINE
    | TOKEN_COMMA
    | TOKEN_EOF
    | TOKEN_GETIP
    | TOKEN_RET
    | TOKEN_JUMP
    | TOKEN_JUMPIFL
    | TOKEN_JUMPIFLE
    | TOKEN_JUMPIFG
    | TOKEN_JUMPIFGE
    | TOKEN_ALLOCA
    | TOKEN_HALT
    | TOKEN_PROC
    | TOKEN_ENDP
    | TOKEN_PUSH
    | TOKEN_POP
    | TOKEN_ADD
    | TOKEN_NOP
    | TOKEN_CALL
    | TOKEN_NCALL
    | TOKEN_WRITE
    | TOKEN_NWRITE
    | TOKEN_READ
    | TOKEN_NREAD
    | TOKEN_end_of_input
    | TOKEN_error
// This type is used to give symbolic names to token indexes, useful for error messages
type nonTerminalId = 
    | NONTERM__startprogram
    | NONTERM_program
    | NONTERM_sourceElementList
    | NONTERM_procDefinition
    | NONTERM_statementList
    | NONTERM_statement
    | NONTERM_statementNoLabel
    | NONTERM_expression

// This function maps tokens to integer indexes
let tagOfToken (t:token) = 
  match t with
  | INTEGER _ -> 0 
  | LABEL _ -> 1 
  | IDENTIFIER _ -> 2 
  | STRING _ -> 3 
  | BOOLEAN _ -> 4 
  | CMP  -> 5 
  | GETSP  -> 6 
  | SWRITE  -> 7 
  | SREAD  -> 8 
  | BYTE  -> 9 
  | WORD  -> 10 
  | DWORD  -> 11 
  | NEWLINE  -> 12 
  | COMMA  -> 13 
  | EOF  -> 14 
  | GETIP  -> 15 
  | RET  -> 16 
  | JUMP  -> 17 
  | JUMPIFL  -> 18 
  | JUMPIFLE  -> 19 
  | JUMPIFG  -> 20 
  | JUMPIFGE  -> 21 
  | ALLOCA  -> 22 
  | HALT  -> 23 
  | PROC  -> 24 
  | ENDP  -> 25 
  | PUSH  -> 26 
  | POP  -> 27 
  | ADD  -> 28 
  | NOP  -> 29 
  | CALL  -> 30 
  | NCALL  -> 31 
  | WRITE  -> 32 
  | NWRITE  -> 33 
  | READ  -> 34 
  | NREAD  -> 35 

// This function maps integer indexes to symbolic token ids
let tokenTagToTokenId (tokenIdx:int) = 
  match tokenIdx with
  | 0 -> TOKEN_INTEGER 
  | 1 -> TOKEN_LABEL 
  | 2 -> TOKEN_IDENTIFIER 
  | 3 -> TOKEN_STRING 
  | 4 -> TOKEN_BOOLEAN 
  | 5 -> TOKEN_CMP 
  | 6 -> TOKEN_GETSP 
  | 7 -> TOKEN_SWRITE 
  | 8 -> TOKEN_SREAD 
  | 9 -> TOKEN_BYTE 
  | 10 -> TOKEN_WORD 
  | 11 -> TOKEN_DWORD 
  | 12 -> TOKEN_NEWLINE 
  | 13 -> TOKEN_COMMA 
  | 14 -> TOKEN_EOF 
  | 15 -> TOKEN_GETIP 
  | 16 -> TOKEN_RET 
  | 17 -> TOKEN_JUMP 
  | 18 -> TOKEN_JUMPIFL 
  | 19 -> TOKEN_JUMPIFLE 
  | 20 -> TOKEN_JUMPIFG 
  | 21 -> TOKEN_JUMPIFGE 
  | 22 -> TOKEN_ALLOCA 
  | 23 -> TOKEN_HALT 
  | 24 -> TOKEN_PROC 
  | 25 -> TOKEN_ENDP 
  | 26 -> TOKEN_PUSH 
  | 27 -> TOKEN_POP 
  | 28 -> TOKEN_ADD 
  | 29 -> TOKEN_NOP 
  | 30 -> TOKEN_CALL 
  | 31 -> TOKEN_NCALL 
  | 32 -> TOKEN_WRITE 
  | 33 -> TOKEN_NWRITE 
  | 34 -> TOKEN_READ 
  | 35 -> TOKEN_NREAD 
  | 38 -> TOKEN_end_of_input
  | 36 -> TOKEN_error
  | _ -> failwith "tokenTagToTokenId: bad token"

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
let prodIdxToNonTerminal (prodIdx:int) = 
  match prodIdx with
    | 0 -> NONTERM__startprogram 
    | 1 -> NONTERM_program 
    | 2 -> NONTERM_sourceElementList 
    | 3 -> NONTERM_sourceElementList 
    | 4 -> NONTERM_procDefinition 
    | 5 -> NONTERM_statementList 
    | 6 -> NONTERM_statementList 
    | 7 -> NONTERM_statement 
    | 8 -> NONTERM_statement 
    | 9 -> NONTERM_statementNoLabel 
    | 10 -> NONTERM_statementNoLabel 
    | 11 -> NONTERM_statementNoLabel 
    | 12 -> NONTERM_statementNoLabel 
    | 13 -> NONTERM_statementNoLabel 
    | 14 -> NONTERM_statementNoLabel 
    | 15 -> NONTERM_statementNoLabel 
    | 16 -> NONTERM_statementNoLabel 
    | 17 -> NONTERM_statementNoLabel 
    | 18 -> NONTERM_statementNoLabel 
    | 19 -> NONTERM_statementNoLabel 
    | 20 -> NONTERM_statementNoLabel 
    | 21 -> NONTERM_statementNoLabel 
    | 22 -> NONTERM_statementNoLabel 
    | 23 -> NONTERM_statementNoLabel 
    | 24 -> NONTERM_statementNoLabel 
    | 25 -> NONTERM_statementNoLabel 
    | 26 -> NONTERM_statementNoLabel 
    | 27 -> NONTERM_statementNoLabel 
    | 28 -> NONTERM_statementNoLabel 
    | 29 -> NONTERM_statementNoLabel 
    | 30 -> NONTERM_statementNoLabel 
    | 31 -> NONTERM_statementNoLabel 
    | 32 -> NONTERM_statementNoLabel 
    | 33 -> NONTERM_statementNoLabel 
    | 34 -> NONTERM_statementNoLabel 
    | 35 -> NONTERM_expression 
    | 36 -> NONTERM_expression 
    | _ -> failwith "prodIdxToNonTerminal: bad production index"

let _fsyacc_endOfInputTag = 38 
let _fsyacc_tagOfErrorTerminal = 36

// This function gets the name of a token as a string
let token_to_string (t:token) = 
  match t with 
  | INTEGER _ -> "INTEGER" 
  | LABEL _ -> "LABEL" 
  | IDENTIFIER _ -> "IDENTIFIER" 
  | STRING _ -> "STRING" 
  | BOOLEAN _ -> "BOOLEAN" 
  | CMP  -> "CMP" 
  | GETSP  -> "GETSP" 
  | SWRITE  -> "SWRITE" 
  | SREAD  -> "SREAD" 
  | BYTE  -> "BYTE" 
  | WORD  -> "WORD" 
  | DWORD  -> "DWORD" 
  | NEWLINE  -> "NEWLINE" 
  | COMMA  -> "COMMA" 
  | EOF  -> "EOF" 
  | GETIP  -> "GETIP" 
  | RET  -> "RET" 
  | JUMP  -> "JUMP" 
  | JUMPIFL  -> "JUMPIFL" 
  | JUMPIFLE  -> "JUMPIFLE" 
  | JUMPIFG  -> "JUMPIFG" 
  | JUMPIFGE  -> "JUMPIFGE" 
  | ALLOCA  -> "ALLOCA" 
  | HALT  -> "HALT" 
  | PROC  -> "PROC" 
  | ENDP  -> "ENDP" 
  | PUSH  -> "PUSH" 
  | POP  -> "POP" 
  | ADD  -> "ADD" 
  | NOP  -> "NOP" 
  | CALL  -> "CALL" 
  | NCALL  -> "NCALL" 
  | WRITE  -> "WRITE" 
  | NWRITE  -> "NWRITE" 
  | READ  -> "READ" 
  | NREAD  -> "NREAD" 

// This function gets the data carried by a token as an object
let _fsyacc_dataOfToken (t:token) = 
  match t with 
  | INTEGER _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | LABEL _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | IDENTIFIER _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | STRING _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | BOOLEAN _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | CMP  -> (null : System.Object) 
  | GETSP  -> (null : System.Object) 
  | SWRITE  -> (null : System.Object) 
  | SREAD  -> (null : System.Object) 
  | BYTE  -> (null : System.Object) 
  | WORD  -> (null : System.Object) 
  | DWORD  -> (null : System.Object) 
  | NEWLINE  -> (null : System.Object) 
  | COMMA  -> (null : System.Object) 
  | EOF  -> (null : System.Object) 
  | GETIP  -> (null : System.Object) 
  | RET  -> (null : System.Object) 
  | JUMP  -> (null : System.Object) 
  | JUMPIFL  -> (null : System.Object) 
  | JUMPIFLE  -> (null : System.Object) 
  | JUMPIFG  -> (null : System.Object) 
  | JUMPIFGE  -> (null : System.Object) 
  | ALLOCA  -> (null : System.Object) 
  | HALT  -> (null : System.Object) 
  | PROC  -> (null : System.Object) 
  | ENDP  -> (null : System.Object) 
  | PUSH  -> (null : System.Object) 
  | POP  -> (null : System.Object) 
  | ADD  -> (null : System.Object) 
  | NOP  -> (null : System.Object) 
  | CALL  -> (null : System.Object) 
  | NCALL  -> (null : System.Object) 
  | WRITE  -> (null : System.Object) 
  | NWRITE  -> (null : System.Object) 
  | READ  -> (null : System.Object) 
  | NREAD  -> (null : System.Object) 
let _fsyacc_gotos = [| 0us; 65535us; 1us; 65535us; 0us; 1us; 1us; 65535us; 0us; 2us; 2us; 65535us; 0us; 4us; 2us; 5us; 1us; 65535us; 7us; 8us; 2us; 65535us; 7us; 10us; 8us; 11us; 3us; 65535us; 7us; 14us; 8us; 14us; 12us; 13us; 6us; 65535us; 18us; 19us; 22us; 23us; 24us; 25us; 26us; 27us; 28us; 29us; 30us; 31us; |]
let _fsyacc_sparseGotoTableRowOffsets = [|0us; 1us; 3us; 5us; 8us; 10us; 13us; 17us; |]
let _fsyacc_stateToProdIdxsTableElements = [| 1us; 0us; 1us; 0us; 2us; 1us; 3us; 1us; 1us; 1us; 2us; 1us; 3us; 1us; 4us; 1us; 4us; 2us; 4us; 6us; 1us; 4us; 1us; 5us; 1us; 6us; 1us; 7us; 1us; 7us; 1us; 8us; 1us; 9us; 1us; 10us; 1us; 11us; 1us; 12us; 1us; 12us; 1us; 13us; 1us; 13us; 1us; 14us; 1us; 14us; 1us; 15us; 1us; 15us; 1us; 16us; 1us; 16us; 1us; 17us; 1us; 17us; 1us; 18us; 1us; 18us; 1us; 19us; 1us; 20us; 1us; 21us; 1us; 22us; 1us; 23us; 1us; 24us; 1us; 24us; 1us; 25us; 1us; 25us; 1us; 26us; 1us; 26us; 1us; 27us; 1us; 28us; 1us; 29us; 1us; 30us; 1us; 31us; 1us; 32us; 1us; 33us; 1us; 34us; 1us; 35us; 1us; 36us; |]
let _fsyacc_stateToProdIdxsTableRowOffsets = [|0us; 2us; 4us; 7us; 9us; 11us; 13us; 15us; 17us; 20us; 22us; 24us; 26us; 28us; 30us; 32us; 34us; 36us; 38us; 40us; 42us; 44us; 46us; 48us; 50us; 52us; 54us; 56us; 58us; 60us; 62us; 64us; 66us; 68us; 70us; 72us; 74us; 76us; 78us; 80us; 82us; 84us; 86us; 88us; 90us; 92us; 94us; 96us; 98us; 100us; 102us; 104us; 106us; |]
let _fsyacc_action_rows = 53
let _fsyacc_actionTableElements = [|1us; 32768us; 24us; 6us; 0us; 49152us; 2us; 32768us; 14us; 3us; 24us; 6us; 0us; 16385us; 0us; 16386us; 0us; 16387us; 1us; 32768us; 2us; 7us; 27us; 32768us; 1us; 12us; 5us; 43us; 6us; 48us; 7us; 49us; 8us; 50us; 9us; 37us; 10us; 39us; 11us; 41us; 15us; 44us; 16us; 15us; 17us; 22us; 18us; 24us; 19us; 26us; 20us; 28us; 21us; 30us; 22us; 36us; 23us; 45us; 26us; 18us; 27us; 20us; 28us; 17us; 29us; 16us; 30us; 46us; 31us; 47us; 32us; 34us; 33us; 35us; 34us; 32us; 35us; 33us; 28us; 32768us; 1us; 12us; 5us; 43us; 6us; 48us; 7us; 49us; 8us; 50us; 9us; 37us; 10us; 39us; 11us; 41us; 15us; 44us; 16us; 15us; 17us; 22us; 18us; 24us; 19us; 26us; 20us; 28us; 21us; 30us; 22us; 36us; 23us; 45us; 25us; 9us; 26us; 18us; 27us; 20us; 28us; 17us; 29us; 16us; 30us; 46us; 31us; 47us; 32us; 34us; 33us; 35us; 34us; 32us; 35us; 33us; 0us; 16388us; 0us; 16389us; 0us; 16390us; 26us; 32768us; 5us; 43us; 6us; 48us; 7us; 49us; 8us; 50us; 9us; 37us; 10us; 39us; 11us; 41us; 15us; 44us; 16us; 15us; 17us; 22us; 18us; 24us; 19us; 26us; 20us; 28us; 21us; 30us; 22us; 36us; 23us; 45us; 26us; 18us; 27us; 20us; 28us; 17us; 29us; 16us; 30us; 46us; 31us; 47us; 32us; 34us; 33us; 35us; 34us; 32us; 35us; 33us; 0us; 16391us; 0us; 16392us; 0us; 16393us; 0us; 16394us; 0us; 16395us; 2us; 32768us; 0us; 51us; 2us; 52us; 0us; 16396us; 1us; 32768us; 2us; 21us; 0us; 16397us; 2us; 32768us; 0us; 51us; 2us; 52us; 0us; 16398us; 2us; 32768us; 0us; 51us; 2us; 52us; 0us; 16399us; 2us; 32768us; 0us; 51us; 2us; 52us; 0us; 16400us; 2us; 32768us; 0us; 51us; 2us; 52us; 0us; 16401us; 2us; 32768us; 0us; 51us; 2us; 52us; 0us; 16402us; 0us; 16403us; 0us; 16404us; 0us; 16405us; 0us; 16406us; 0us; 16407us; 1us; 32768us; 0us; 38us; 0us; 16408us; 1us; 32768us; 0us; 40us; 0us; 16409us; 1us; 32768us; 0us; 42us; 0us; 16410us; 0us; 16411us; 0us; 16412us; 0us; 16413us; 0us; 16414us; 0us; 16415us; 0us; 16416us; 0us; 16417us; 0us; 16418us; 0us; 16419us; 0us; 16420us; |]
let _fsyacc_actionTableRowOffsets = [|0us; 2us; 3us; 6us; 7us; 8us; 9us; 11us; 39us; 68us; 69us; 70us; 71us; 98us; 99us; 100us; 101us; 102us; 103us; 106us; 107us; 109us; 110us; 113us; 114us; 117us; 118us; 121us; 122us; 125us; 126us; 129us; 130us; 131us; 132us; 133us; 134us; 135us; 137us; 138us; 140us; 141us; 143us; 144us; 145us; 146us; 147us; 148us; 149us; 150us; 151us; 152us; 153us; |]
let _fsyacc_reductionSymbolCounts = [|1us; 2us; 1us; 2us; 4us; 1us; 2us; 2us; 1us; 1us; 1us; 1us; 2us; 2us; 2us; 2us; 2us; 2us; 2us; 1us; 1us; 1us; 1us; 1us; 2us; 2us; 2us; 1us; 1us; 1us; 1us; 1us; 1us; 1us; 1us; 1us; 1us; |]
let _fsyacc_productionToNonTerminalTable = [|0us; 1us; 2us; 2us; 3us; 4us; 4us; 5us; 5us; 6us; 6us; 6us; 6us; 6us; 6us; 6us; 6us; 6us; 6us; 6us; 6us; 6us; 6us; 6us; 6us; 6us; 6us; 6us; 6us; 6us; 6us; 6us; 6us; 6us; 6us; 7us; 7us; |]
let _fsyacc_immediateActions = [|65535us; 49152us; 65535us; 16385us; 16386us; 16387us; 65535us; 65535us; 65535us; 16388us; 16389us; 16390us; 65535us; 16391us; 16392us; 16393us; 16394us; 16395us; 65535us; 16396us; 65535us; 16397us; 65535us; 16398us; 65535us; 16399us; 65535us; 16400us; 65535us; 16401us; 65535us; 16402us; 16403us; 16404us; 16405us; 16406us; 16407us; 65535us; 16408us; 65535us; 16409us; 65535us; 16410us; 16411us; 16412us; 16413us; 16414us; 16415us; 16416us; 16417us; 16418us; 16419us; 16420us; |]
let _fsyacc_reductions ()  =    [| 
# 322 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data :  Program )) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
                      raise (Microsoft.FSharp.Text.Parsing.Accept(Microsoft.FSharp.Core.Operators.box _1))
                   )
                 : '_startprogram));
# 331 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : 'sourceElementList)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 25 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                                   Program (List.rev _1) 
                   )
# 25 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 :  Program ));
# 342 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : 'procDefinition)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 28 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                          [_1] 
                   )
# 28 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'sourceElementList));
# 353 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : 'sourceElementList)) in
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : 'procDefinition)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 29 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                                        _2::_1 
                   )
# 29 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'sourceElementList));
# 365 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : string)) in
            let _3 = (let data = parseState.GetInput(3) in (Microsoft.FSharp.Core.Operators.unbox data : 'statementList)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 32 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                                         procedureDefinition(_2, List.rev _3) 
                   )
# 32 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'procDefinition));
# 377 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : 'statement)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 35 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                       [_1] 
                   )
# 35 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementList));
# 388 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : 'statementList)) in
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : 'statement)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 36 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                                 _2::_1 
                   )
# 36 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementList));
# 400 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : string)) in
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : 'statementNoLabel)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 39 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                                label(_1, _2) 
                   )
# 39 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statement));
# 412 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : 'statementNoLabel)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 40 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                            _1 
                   )
# 40 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statement));
# 423 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 43 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                  ret() 
                   )
# 43 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 433 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 44 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                  nop() 
                   )
# 44 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 443 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 45 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                  add() 
                   )
# 45 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 453 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : 'expression)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 46 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                           push(_2) 
                   )
# 46 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 464 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : string)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 47 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                          pop(_2) 
                   )
# 47 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 475 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : 'expression)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 48 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                           jump(_2) 
                   )
# 48 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 486 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : 'expression)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 49 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                             jumpIf(_2, false, true) 
                   )
# 49 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 497 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : 'expression)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 50 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                              jumpIf(_2, true, true) 
                   )
# 50 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 508 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : 'expression)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 51 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                             jumpIf(_2, false, false) 
                   )
# 51 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 519 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : 'expression)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 52 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                              jumpIf(_2, true, false) 
                   )
# 52 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 530 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 53 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                   read() 
                   )
# 53 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 540 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 54 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                    readNative() 
                   )
# 54 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 550 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 55 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                    write() 
                   )
# 55 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 560 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 56 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                    writeNative() 
                   )
# 56 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 570 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 57 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                    alloca() 
                   )
# 57 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 580 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : int32)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 58 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                         memoryByte(_2) 
                   )
# 58 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 591 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : int32)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 59 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                         memoryWord(_2) 
                   )
# 59 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 602 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : int32)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 60 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                          memoryDword(_2) 
                   )
# 60 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 613 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 61 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                  compare() 
                   )
# 61 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 623 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 62 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                    getIp() 
                   )
# 62 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 633 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 63 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                   halt() 
                   )
# 63 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 643 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 64 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                   call() 
                   )
# 64 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 653 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 65 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                    callNative() 
                   )
# 65 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 663 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 66 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                    getSp() 
                   )
# 66 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 673 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 67 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                    stackWrite() 
                   )
# 67 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 683 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 68 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                    stackRead() 
                   )
# 68 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'statementNoLabel));
# 693 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : int32)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 71 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                     number(_1) 
                   )
# 71 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'expression));
# 704 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : string)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 72 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                                                       identifier(_1) 
                   )
# 72 "ES.Sacara.Ir.Parser\SacaraIrParser.fsy"
                 : 'expression));
|]
# 716 "ES.Sacara.Ir.Parser\SacaraIrParser.fs"
let tables () : Microsoft.FSharp.Text.Parsing.Tables<_> = 
  { reductions= _fsyacc_reductions ();
    endOfInputTag = _fsyacc_endOfInputTag;
    tagOfToken = tagOfToken;
    dataOfToken = _fsyacc_dataOfToken; 
    actionTableElements = _fsyacc_actionTableElements;
    actionTableRowOffsets = _fsyacc_actionTableRowOffsets;
    stateToProdIdxsTableElements = _fsyacc_stateToProdIdxsTableElements;
    stateToProdIdxsTableRowOffsets = _fsyacc_stateToProdIdxsTableRowOffsets;
    reductionSymbolCounts = _fsyacc_reductionSymbolCounts;
    immediateActions = _fsyacc_immediateActions;
    gotos = _fsyacc_gotos;
    sparseGotoTableRowOffsets = _fsyacc_sparseGotoTableRowOffsets;
    tagOfErrorTerminal = _fsyacc_tagOfErrorTerminal;
    parseError = (fun (ctxt:Microsoft.FSharp.Text.Parsing.ParseErrorContext<_>) -> 
                              match parse_error_rich with 
                              | Some f -> f ctxt
                              | None -> parse_error ctxt.Message);
    numTerminals = 39;
    productionToNonTerminalTable = _fsyacc_productionToNonTerminalTable  }
let engine lexer lexbuf startState = (tables ()).Interpret(lexer, lexbuf, startState)
let program lexer lexbuf :  Program  =
    Microsoft.FSharp.Core.Operators.unbox ((tables ()).Interpret(lexer, lexbuf, 0))