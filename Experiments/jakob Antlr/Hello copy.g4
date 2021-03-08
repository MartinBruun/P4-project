// Define a grammar called Hello
grammar Hello .


Prog  ->  Shapes DrawFunction   .

// #Shapes
Shapes  -> ShapeFunction Shapes |   .

ShapeFunction  -> 'shape' Identifier '{'ShapeElements Shapes '}'   .

Id   -> [a-zA-Z]+   .

ShapeElements  -> ShapeElement ' .' ShapeElements |   .

ShapeElement  -> DrawType DrawTypePostFix   . 

DrawType  -> 'line' | 'curve' '.' ( Radius )   .

DrawTypePostFix  -> '.' Commands   .

// #Commands
Commands  -> StartCommand |  FollowCommand   .

StartCommand  -> 'From' '(' Position ')' '.' FollowCommand   . 

FollowCommand  -> 'To' '(' Position ')'  FollowCommandPostfix   .

FollowCommandPostfix  -> '.' FunctionalPostfix |   .

FunctionalPostfix  -> FollowCommand | 'highlight'   .

// #Position
Position  -> FloatNumber ',' FloatNumber | Point   .
Point     -> Identifier   .
Radius    -> FloatNumber   .

// #Draw
DrawFunction   -> 'draw' '{' IdCalls '}'   .
IdCalls         -> Identifier ';' IdCalls |   .


// #Terminal definitions
// dot  -> '_'   .
// shapeDeclarationSymbol -> 'Shape'  . 
// lineCommandSymbol      -> 'Line'  .
// curveCommandSymbol     -> 'Curve'  . 
// from                   -> 'From'  . 
// to                     -> 'To'  . 
// bodyStartSymbol        -> '{'  . 
// bodyEndSymbol          -> '}'  . 
// tupleStart             -> '('  . 
// tupleEnd               -> ')'  . 
// statementTerminator    -> ' .'  .
// separator              -> ','  . 
// pointDeclarationSymbol  -> 'point' . 
// numberDeclarationSymbol -> 'number'  . 
// assignmentSymbol        -> '='  . 
Identifier              -> [a-zA-Z][a-zA-Z0-9]*  . 
// IntNumber               -> [0-9]+ . 
FloatNumber             -> [0-9]+'  .'[0-9]* . 

// draw                    -> 'draw' .
WS -> [ \t\r\n]+  -> skip  . // skip spaces, tabs, newlines
