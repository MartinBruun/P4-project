grammar Hello;

@header {
testGrammar dk.saxjax
}
WS
    : [ \t\r\n]+ -> skip
    ;
IDENTIFIER
    : [A-Za-z0-9]+
    ;
NUMBER
    :[1-9]+[0-9]*('.'[0-9]+[0-9]*)
    ;
shapeDeclSymbol
    : 'shape'
    ;


start: shapes 'draw'
    ;

shapes
    : shape+
    ;

shape
    : shapeDeclSymbol IDENTIFIER '{' ((drawType+)(shapes)?)* '}'
    ;

drawType
    : 'line'  lineCommand
    | 'curve' curveCommand
    | IDENTIFIER '.' drawType
    | IDENTIFIER manipulateCommand+
    | IDENTIFIER ';'
    ;

commands
    : lineCommand
    | curveCommand
    ;

lineCommand
    :  startCommand followCommand*';'
    ;
curveCommand
    :  lineCommand (radiusCommand)? ';'
    ;

startCommand
    : '.' 'from' '('point')' //'.''to''('point')'
    | followCommand
    ;

followCommand
    : toCommand
    | radiusCommand
    ;

toCommand
    : '.' 'to''('point')'
    ;

radiusCommand
    : '.' 'radius' '('(NUMBER|IDENTIFIER)')'
    ;

manipulateCommand
    : '.''rotate''('(NUMBER|IDENTIFIER)')' ';'

    ;

point
    : NUMBER ',' NUMBER
    | IDENTIFIER ;
