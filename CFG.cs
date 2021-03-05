// Generate the Context Free Grammar on the following website.
// https://mdaines.github.io/grammophone/#/

Program         -> Shapes Draw . 



#Shapes and declarations
Shapes          -> Shape Shapes 
                | . 

Shape           -> $shapeDeclarationSymbol $identifier $bodyStartSymbol ShapeBody $bodyEndSymbol . 

ShapeBody       -> Declarations Motions . 

Declarations    -> PointDeclaration Declarations 
                | NumberDeclaration Declarations 
                | . 


PointDeclaration  -> $pointDeclarationSymbol  $identifier $assignmentSymbol PointReference $statementTerminator . 

NumberDeclaration -> $numberDeclarationSymbol $identifier $assignmentSymbol Number $statementTerminator . 



#Motions, lines and curves,
Motions -> Motion Motions 
        | . 

Motion -> Line $statementTerminator | Curve $statementTerminator. 

Curve -> $curveCommandSymbol FromCommand ToCommand CurveRadiusSymbol .

CurveRadiusSymbol -> "with radius" Number ClockwiseOrNot .

ClockwiseOrNot -> counterclockwise |  .

Line -> $lineCommandSymbol InitiateMotions . 

InitiateMotions -> FromCommand ToCommand ToCommands . 

FromCommand -> $dot $from PointReference . 

PointReference -> $tupleStart Number $separator Number $tupleEnd       
                | $tupleStart $identifier $tupleEnd . 

Number -> $intNumber 
        | $floatNumber . 

ToCommands -> ToCommand ToCommands 
            | . 

ToCommand -> $dot $to PointReference . 

Draw -> $draw $bodyStartSymbol DrawShapes $bodyEndSymbol . 

DrawShapes -> DrawShape DrawShapes 
            | . 

DrawShape -> $identifier $statementTerminator . 

  

# Definition of Terminals: 
$shapeDeclarationSymbol -> "Shape" . 
$lineCommandSymbol      -> "Line" .
$curveCommandSymbol     -> "Curve" . 
$from                   -> "From" . 
$dot                    -> dot .
$to                     -> "To" . 
$bodyStartSymbol        -> { . 
$bodyEndSymbol          -> } . 
$tupleStart             -> ( . 
$tupleEnd               -> ) . 
$statementTerminator    -> ; .
$separator              -> , . 
$pointDeclarationSymbol  -> point. 
$numberDeclarationSymbol -> "number" . 
$assignmentSymbol        -> = . 
$identifier              -> [a-zA-Z][a-zA-Z0-9]* . 
$intNumber               -> [0-9]+. 
$floatNumber             -> [[0-9]+DOT[0-9]*]. 

$draw                    -> draw.