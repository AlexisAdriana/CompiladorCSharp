using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;

namespace ProyectoCompilador.Recursos
{
    class Gramatica : Grammar
    {
        public Gramatica() : base(caseSensitive: true)
        {

            StringLiteral CADENA = new StringLiteral("cadena", "\"");
            RegexBasedTerminal letras = new RegexBasedTerminal("letras", "[(a-z)*(A-Z)*(0-9)*]+");
            var ENTERO = new RegexBasedTerminal("Entero", "[0-9]+");
            var DECIMAL = new RegexBasedTerminal("Decimal", "[0-9]+[.][0-9]+");
            IdentifierTerminal IDENTIFICADOR = new IdentifierTerminal("ID");
            var entradaID = new NonTerminal("entradaID");

            //CommentTerminal comentarioBloque = new CommentTerminal("comentarioBloque", "/", "/");

            CommentTerminal comentarioLinea = new CommentTerminal("SingleLineComment", "//", "\r", "\n", "\u2085", "\u2028", "\u2029");
            CommentTerminal comentarioBloque = new CommentTerminal("DelimitedComment", "/*", "*/");
            NonGrammarTerminals.Add(comentarioLinea);
            NonGrammarTerminals.Add(comentarioBloque);

            #region PalabrasReservadas
            KeyTerm dosPuntos = ToTerm(":", "dosPuntos");
            KeyTerm puntoComa = ToTerm(";", "puntoComa");
            KeyTerm punto = ToTerm(".", "punto");
            KeyTerm coma = ToTerm(",", "coma");
            KeyTerm parentesisIzq = ToTerm("(", "parentesisIzq");
            KeyTerm parentesisDer = ToTerm(")", "parentesisDer");
            KeyTerm llaveIzq = ToTerm("{", "llaveIzq");
            KeyTerm llaveDer = ToTerm("}", "llaveDer");
            KeyTerm corcheteIzq = ToTerm("[", "corcheteIzq");
            KeyTerm corcheteDer = ToTerm("]", "corcheteDer");

            KeyTerm plus = ToTerm("+", "plus");
            KeyTerm minus = ToTerm("-", "minus");
            KeyTerm kwComa = ToTerm(",");
            KeyTerm por = ToTerm("*", "por");
            KeyTerm div = ToTerm("/", "div");
            KeyTerm plusPlus = ToTerm("++", "plusPlus");
            KeyTerm minusMinus = ToTerm("--", "menosMenos");

            //Comparadores
            KeyTerm mayorQue = ToTerm(">", "mayorQue");
            KeyTerm menorQue = ToTerm("<", "menorQue");
            KeyTerm igual = ToTerm("=", "igual");
            KeyTerm mayorIgual = ToTerm(">=", "mayorIgual");
            KeyTerm menorIgual = ToTerm("<=", "menorIgual");
            KeyTerm diferente = ToTerm("!=", "diferente");
            KeyTerm igualIgual = ToTerm("==", "igualIgual");

            //Variables
            KeyTerm varInt = ToTerm("int");
            KeyTerm varFloat = ToTerm("float");
            KeyTerm varString = ToTerm("string");
            KeyTerm varBoolean = ToTerm("bool");

            //Ciclos y condicionales
            KeyTerm kwNew = ToTerm("new");
            KeyTerm condIf = ToTerm("if");
            KeyTerm condElif = ToTerm("elif");
            KeyTerm condElse = ToTerm("else");
            KeyTerm kwBreack = ToTerm("break");
            KeyTerm kwCase = ToTerm("case");
            KeyTerm kwClass = ToTerm("class");
            KeyTerm kwTry = ToTerm("Try");
            KeyTerm kwCatch = ToTerm("Catch");
            KeyTerm kwWhile = ToTerm("while");
            KeyTerm kwDo = ToTerm("Do");
            KeyTerm kwFor = ToTerm("for");
            KeyTerm kwPublic = ToTerm("public");
            KeyTerm kwThrow = ToTerm("Throw");
            KeyTerm kwVoid = ToTerm("Void");
            KeyTerm kwSwitch = ToTerm("switch");
            KeyTerm kwTrue = ToTerm("true");
            KeyTerm kwFalse = ToTerm("false");
            KeyTerm signoOR = ToTerm("|");
            KeyTerm signoAND = ToTerm("&&");


            //Para using
            KeyTerm kwUsing = ToTerm("using");
            KeyTerm kwSystem = ToTerm("System");
            KeyTerm kwCollection = ToTerm("Collections");
            KeyTerm kwIO = ToTerm("IO");
            KeyTerm kwGeneric = ToTerm("Generic");
            KeyTerm kwLinq = ToTerm("Linq");
            KeyTerm kwText = ToTerm("Text");
            KeyTerm kwThreading = ToTerm("Threading");
            KeyTerm kwTasks = ToTerm("Tasks");

            KeyTerm kwConsole = ToTerm("Console");
            KeyTerm kwWrite = ToTerm("Write");
            KeyTerm kwWriteLn = ToTerm("WriteLine");

            KeyTerm kwDefault = ToTerm("default");
            #endregion

            #region NoTerminales
            NonTerminal ini = new NonTerminal("ini");
            NonTerminal instruccion = new NonTerminal("instruccion");
            NonTerminal instrucciones = new NonTerminal("instrucciones");
            NonTerminal expresion_numerica = new NonTerminal("expresion_numerica");
            NonTerminal expresion_cadena = new NonTerminal("expresion_cadena");
            NonTerminal expresion_logica = new NonTerminal("expresion_logica");

            //No terminales para declarar variables
            NonTerminal declararVar = new NonTerminal("decVar");
            NonTerminal decInt = new NonTerminal("decInt");
            NonTerminal decFloat = new NonTerminal("decFloat");
            NonTerminal decString = new NonTerminal("decString");
            NonTerminal decBool = new NonTerminal("decBool");

            NonTerminal S = new NonTerminal("S");
            NonTerminal INICIO = new NonTerminal("INICIO");
            NonTerminal PROGRAMA = new NonTerminal("PROGRAMA");
            NonTerminal PROGRAMAs = new NonTerminal("PROGRAMAs");
            NonTerminal PROGRAMAc = new NonTerminal("PROGRAMAc");
            NonTerminal CONSTRUIR = new NonTerminal("CONSTRUIR");

            NonTerminal condicionIF = new NonTerminal("condicionIF");
            NonTerminal condicionIFCP = new NonTerminal("condicionIFCP");
            NonTerminal condicionIFSP = new NonTerminal("condicionIFSP");
            NonTerminal condicionIFELSE = new NonTerminal("condicionIFELSE");
            NonTerminal condicionalIFELSEIF = new NonTerminal("condicionIFELSEIF");
            NonTerminal condicionELSE = new NonTerminal("condicionELSE");
            NonTerminal condicionELSEIF = new NonTerminal("condicionELSEIF");
            NonTerminal expComparacion = new NonTerminal("expComparacion");
            NonTerminal nuevaCondicion = new NonTerminal("nuevaCondicion");
            NonTerminal nuevaCondicion2 = new NonTerminal("nuevaCondicion2");
            NonTerminal compIgualDiferente = new NonTerminal("compIgualDiferente");
            NonTerminal compMayorMenor = new NonTerminal("comMayorMenor");
            NonTerminal compMayorMenorIgual = new NonTerminal("comMayorMenor");
            NonTerminal compBool = new NonTerminal("comBool");

            NonTerminal condicionSwitch = new NonTerminal("condicionSwitch");
            NonTerminal switchOpcion = new NonTerminal("switchOpcion");
            NonTerminal opcionCase = new NonTerminal("opcionCase");
            NonTerminal opcionDefault = new NonTerminal("opcionDefault");



            NonTerminal imprimir = new NonTerminal("imprimir");
            NonTerminal imprimirWrite = new NonTerminal("imprimirWrite");
            NonTerminal imprimirWriteLn = new NonTerminal("imprimirWriteLn");
            NonTerminal textoOVariable = new NonTerminal("textoOVariable");

            NonTerminal operaciones = new NonTerminal("operaciones");
            NonTerminal opeSuma = new NonTerminal("opeSuma");
            NonTerminal opeResta = new NonTerminal("opeResta");
            NonTerminal opeMultiplicacion = new NonTerminal("opeMultiplicacion");
            NonTerminal opeDivision = new NonTerminal("opeDivision");
            NonTerminal opeCompuesta = new NonTerminal("opeCompuesta");
            NonTerminal datoEntradaOpe = new NonTerminal("datoEntradaOpe");

            NonTerminal nameSpace = new NonTerminal("nameSpace");
            NonTerminal ntClass = new NonTerminal("ntClass");
            NonTerminal ntMain = new NonTerminal("ntMain");
            NonTerminal ntPublic = new NonTerminal("ntPublic");

            NonTerminal asignadorVariable = new NonTerminal("asignadorVariable");
            NonTerminal BoolAsignacionVariable = new NonTerminal("BoolAsignacionVariable");

            NonTerminal System = new NonTerminal("System");
            NonTerminal LibreriasE = new NonTerminal("LibreriasE");

            NonTerminal condicionWhile = new NonTerminal("CondicionWhile");
            NonTerminal condicionDoWhile = new NonTerminal("CondicionDoWhile");
            NonTerminal cicloswhile = new NonTerminal("CiclosWhile");

            NonTerminal declararArreglo = new NonTerminal("Arreglo");
            NonTerminal declararArregloInt = new NonTerminal("Arreglo");
            NonTerminal declararArregloDecimal = new NonTerminal("Arreglo");
            NonTerminal declararArregloString = new NonTerminal("Arreglo");
            NonTerminal iniciarArreglos = new NonTerminal("Iniciar Arreglo");

            NonTerminal ValoresArreglo = new NonTerminal("Valores Arreglo");

            NonTerminal contador = new NonTerminal("contador");
            NonTerminal acumulador = new NonTerminal("acumulador");

            NonTerminal cicloFor = new NonTerminal("for");
            #endregion


            #region Gramatica
            S.Rule = INICIO;
            INICIO.Rule = MakePlusRule(INICIO, CONSTRUIR);
            //CONSTRUIR.Rule = (System + System + System + System + System )+ nameSpace;
            CONSTRUIR.Rule = System + nameSpace;
            PROGRAMA.Rule =  PROGRAMAs | PROGRAMAc; 
            PROGRAMAs.Rule = (declararVar | acumulador | contador |condicionIF | condicionIFELSE | condicionalIFELSEIF | condicionSwitch | imprimir | operaciones | asignadorVariable
                            | cicloswhile | declararArreglo | cicloFor);
            PROGRAMAc.Rule = PROGRAMAs + PROGRAMA;


            entradaID.Rule = MakePlusRule(entradaID, ToTerm(","), IDENTIFICADOR);

            //--------------------------------Sirve-------------------/
            //-----------------------GRAMATICA USING
            LibreriasE.Rule = punto + (kwCollection + punto + kwGeneric + puntoComa | kwIO + puntoComa | kwLinq + puntoComa | kwText + puntoComa | kwThreading + punto + kwTasks + puntoComa);
            System.Rule = (kwUsing + (kwSystem) + (LibreriasE | puntoComa)) | ((kwUsing + (kwSystem) + (LibreriasE | puntoComa)) + System);

            //-------------------------GRAMATICA DECLARAR UNA CLASE
            nameSpace.Rule = "namespace" + entradaID + llaveIzq + ntClass + llaveDer;
            ntClass.Rule = kwClass + entradaID + llaveIzq + (ntPublic | ntMain) + llaveDer;
            ntMain.Rule = ("static void Main" + parentesisIzq + varString + "[] args" + parentesisDer + llaveIzq + llaveDer)
                | ("static void Main" + parentesisIzq + varString + "[] args" + parentesisDer + llaveIzq + PROGRAMA + llaveDer);
            ntPublic.Rule = kwPublic + entradaID + "()" + llaveIzq + PROGRAMA + llaveDer;

            //----------------------GRAMATICA DECLARAR UNA VARIABLE
            declararVar.Rule = decInt | decFloat | decString | decBool | declararVar;

            decInt.Rule = varInt + entradaID + igual + ENTERO + puntoComa;
            decFloat.Rule = (varFloat + entradaID + igual + DECIMAL + puntoComa);
            decString.Rule = (varString + entradaID + igual + (CADENA) + puntoComa);
            decBool.Rule = (varBoolean + entradaID + igual + (kwTrue | kwFalse) + puntoComa);

            //-----------------GRAMATICA IF
            condicionIF.Rule = (condicionIFCP);
            condicionIFCP.Rule = (condIf + parentesisIzq + (expComparacion | (expComparacion + nuevaCondicion)) + parentesisDer + llaveIzq + ((PROGRAMA + llaveDer) | llaveDer));
            expComparacion.Rule = (parentesisIzq + (compIgualDiferente | compMayorMenor | compMayorMenorIgual | compBool) + parentesisDer) | (compIgualDiferente | compMayorMenor | compMayorMenorIgual | compBool);
            compIgualDiferente.Rule = ((DECIMAL + igualIgual + (DECIMAL | entradaID)) | (ENTERO + igualIgual + (ENTERO | entradaID)) | (entradaID + igualIgual + (entradaID | ENTERO | DECIMAL | CADENA)) | (CADENA + igualIgual + (CADENA | entradaID))) |
                                      ((DECIMAL + diferente + (DECIMAL | entradaID)) | (ENTERO + diferente + (ENTERO | entradaID)) | (entradaID + diferente + (entradaID | ENTERO | DECIMAL | CADENA)) | (CADENA + diferente + (CADENA | entradaID)));
            compMayorMenor.Rule = ((DECIMAL + mayorQue + (DECIMAL | entradaID)) | (ENTERO + mayorQue + (ENTERO | entradaID)) | (entradaID + mayorQue + (entradaID | ENTERO | DECIMAL | CADENA))) |
                                      ((DECIMAL + menorQue + (DECIMAL | entradaID)) | (ENTERO + menorQue + (ENTERO | entradaID)) | (entradaID + menorQue + (entradaID | ENTERO | DECIMAL | CADENA)));
            compMayorMenorIgual.Rule = ((DECIMAL + mayorIgual + (DECIMAL | entradaID)) | (ENTERO + mayorIgual + (ENTERO | entradaID)) | (entradaID + mayorIgual + (entradaID | ENTERO | DECIMAL | CADENA))) |
                                      ((DECIMAL + menorIgual + (DECIMAL | entradaID)) | (ENTERO + menorIgual + (ENTERO | entradaID)) | (entradaID + menorIgual + (entradaID | ENTERO | DECIMAL | CADENA)));
            compBool.Rule = entradaID + igual + (kwTrue | kwFalse);
            nuevaCondicion.Rule = (signoAND | signoOR) + expComparacion | (signoAND | signoOR) + expComparacion + nuevaCondicion;
            

            //------------------------------GRAMATICA IF ELSE
            condicionIFELSE.Rule = condicionIF + condicionELSE;
            condicionELSE.Rule = (condElse + llaveIzq + llaveDer) | (condElse + llaveIzq + PROGRAMA + llaveDer);

            //--------------------------GRAMATICA ELSE IF
            condicionalIFELSEIF.Rule = condicionIF + condicionELSEIF;
            condicionELSEIF.Rule = condElse + (condicionIF | condicionELSE | condicionalIFELSEIF);

            //------------------------------GRAMATICA SWITCH
            opcionDefault.Rule = kwDefault + dosPuntos + PROGRAMA + kwBreack + puntoComa;
            opcionCase.Rule = kwCase + switchOpcion + dosPuntos + PROGRAMA + kwBreack + puntoComa + (opcionCase | opcionDefault);
            switchOpcion.Rule = DECIMAL | ENTERO | CADENA | entradaID;
            condicionSwitch.Rule = kwSwitch + parentesisIzq + switchOpcion + parentesisDer + llaveIzq
                                + opcionCase + llaveDer; //cierre de Switch

            //---------------------------GRAMATICA IMPRIMIR EN CONSOLA
            imprimir.Rule = kwConsole + punto + (imprimirWrite | imprimirWriteLn) + puntoComa;
            imprimirWrite.Rule = kwWrite + parentesisIzq + textoOVariable + parentesisDer;
            imprimirWriteLn.Rule = kwWriteLn + parentesisIzq + textoOVariable + parentesisDer;
            textoOVariable.Rule = (CADENA | entradaID) | ((CADENA | entradaID) + plus + textoOVariable);

            //---------------------------GRAMATICA OPERACIONES
            operaciones.Rule = ((opeSuma | opeResta | opeMultiplicacion | opeDivision) + puntoComa) | (opeCompuesta + puntoComa) |
                                (parentesisIzq + (opeSuma | opeResta | opeMultiplicacion | opeDivision) + parentesisDer + puntoComa) | (parentesisIzq + opeCompuesta + parentesisDer + puntoComa);
            opeSuma.Rule = datoEntradaOpe | (datoEntradaOpe + plus + opeSuma) | (parentesisIzq + opeSuma + parentesisDer) | (plus + datoEntradaOpe);
            opeResta.Rule = datoEntradaOpe | (datoEntradaOpe + minus + opeResta) | (parentesisIzq + opeResta + parentesisDer) | (minus + datoEntradaOpe);
            opeMultiplicacion.Rule = datoEntradaOpe | (datoEntradaOpe + por + opeMultiplicacion) | (parentesisIzq + opeMultiplicacion + parentesisDer) | (por + datoEntradaOpe) | (parentesisIzq + opeMultiplicacion + parentesisDer);
            opeDivision.Rule = datoEntradaOpe | (datoEntradaOpe + div + opeDivision) | (parentesisIzq + opeDivision + parentesisDer) | (div + datoEntradaOpe);
            opeCompuesta.Rule = (opeSuma | opeResta | opeMultiplicacion | opeDivision) | ((opeSuma | opeResta | opeMultiplicacion | opeDivision) + opeCompuesta);
            datoEntradaOpe.Rule = (ENTERO | DECIMAL | entradaID) | (parentesisIzq + datoEntradaOpe + parentesisDer) | (parentesisIzq + (opeSuma | opeResta | opeMultiplicacion | opeDivision) + parentesisDer);

            //-------------------------------GRAMATICA ASIGNACION
            BoolAsignacionVariable.Rule = (kwTrue | kwFalse);
            asignadorVariable.Rule = entradaID + igual + ((operaciones) | (((BoolAsignacionVariable) | (DECIMAL) | (ENTERO) | (CADENA)) + puntoComa));

            //------------------------------------GRAMATICA WHILE Y DOWHILE
            cicloswhile.Rule = condicionWhile | condicionDoWhile;
            condicionWhile.Rule = kwWhile + parentesisIzq + (expComparacion | expComparacion + nuevaCondicion) + parentesisDer + (llaveIzq + PROGRAMA | llaveIzq) + llaveDer;
            condicionDoWhile.Rule = kwDo + ((llaveIzq + PROGRAMA) | llaveIzq) + llaveDer + kwWhile + parentesisIzq + (expComparacion | expComparacion + nuevaCondicion) + parentesisDer + puntoComa;

            //-------------------------------GRAMATICA ARREGLOS
            ValoresArreglo.Rule = ((kwComa | ENTERO) + (ValoresArreglo | llaveDer) | (kwComa | DECIMAL) + (ValoresArreglo | llaveDer) | (kwComa | CADENA) + (ValoresArreglo | llaveDer));
            declararArreglo.Rule = declararArregloInt | declararArregloString | declararArregloDecimal;
            declararArregloInt.Rule = (varInt + corcheteIzq + corcheteDer + entradaID + (puntoComa | (igual + kwNew + varInt + corcheteIzq + ENTERO + corcheteDer + (puntoComa | (llaveIzq + ValoresArreglo + puntoComa)))));
            declararArregloString.Rule = (varString + corcheteIzq + corcheteDer + entradaID + (puntoComa | (igual + kwNew + varString + corcheteIzq + ENTERO + corcheteDer + (puntoComa | (llaveIzq + ValoresArreglo + puntoComa)))));
            declararArregloDecimal.Rule = (varFloat + corcheteIzq + corcheteDer + entradaID + (puntoComa | (igual + kwNew + varFloat + corcheteIzq + ENTERO + corcheteDer + (puntoComa | (llaveIzq + ValoresArreglo + puntoComa)))));

            //----------------------GRAMATICA FOR
            cicloFor.Rule = kwFor + parentesisIzq +
                    varInt + entradaID + igual + ENTERO + puntoComa +
                    entradaID + (menorQue | menorIgual | igual | mayorQue | mayorIgual) + ENTERO + puntoComa +
                    entradaID + (plusPlus | minusMinus) + parentesisDer + llaveIzq + (llaveDer | (PROGRAMA + llaveDer));
            //-----------------------Gramatica acumuladores y contadores

            acumulador.Rule = ((entradaID + igual + (plus | minus) + entradaID + puntoComa) |
                             (entradaID + igual + entradaID + (minus | plus) + entradaID + puntoComa));
            //-------------------------CONTADOR
            contador.Rule = ((entradaID + (plusPlus | minusMinus) + puntoComa) |
                            (entradaID + (plus | minus) + igual + (ENTERO | DECIMAL) + puntoComa) |
                            (entradaID + igual + entradaID + (plus | minus) + (ENTERO | DECIMAL) + puntoComa));


            //----------------------SIGNOS PUNTUACION Y MAS
            this.Root = S;
            this.MarkTransient(S);
            //this.RegisterOperators(20, Associativity.Left, mas, menos);
            //this.RegisterOperators(30, Associativity.Left, por, div);
            this.MarkPunctuation("(", ")", ",", ":", ";", "=");
            #endregion

        }
    }
}
