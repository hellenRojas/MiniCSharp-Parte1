﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using AnalizadorSintactico;
using System.Windows.Forms;

class PrettyPrint : Parser1BaseVisitor<Object>
{

    //private var for tree
    private TreeView treeview;

    public PrettyPrint(TreeView tree)
    {
        this.treeview = tree;
    }
   
	public virtual object VisitClassDeclAST([NotNull] Parser1.ClassDeclASTContext context) {
        TreeNode clase = new TreeNode(context.CLASE().ToString());
        TreeNode ident = new TreeNode(context.IDENT().ToString());
        TreeNode CD = new TreeNode(context.COR_DER().ToString());
        TreeNode CI = new TreeNode(context.COR_IZQ().ToString());
        int largo = 4 + context.varDecl().Count();
        TreeNode[] arreglo = new TreeNode[largo];
        arreglo[0] = clase;
        arreglo[1] = ident;
        arreglo[2] = CD;
        int cont = 3;
        for (int i = 0; i <= context.varDecl().Count(); i++)
        {
            TreeNode vardecl = (TreeNode)Visit(context.varDecl(i));
            arreglo[cont] = vardecl;
            cont++;
        }
        arreglo[cont] = CI;
        TreeNode final = new TreeNode("ClassDecl", arreglo);
            return final; 
    }

	
    public virtual object VisitCondTermAST([NotNull] Parser1.CondTermASTContext context) {
        TreeNode condfact1 = (TreeNode)Visit(context.condFact(0));
        int largo = context.Y().Count() + context.condFact().Count();
        TreeNode[] arreglo = new TreeNode[largo];
        arreglo[0] = condfact1;
        int count = 1; //contador del arreglo
        int iAnd = 0; //contador para AND
        for (int i = 1; i <= context.condFact().Count(); i++)
        {
            TreeNode and = new TreeNode(context.Y(iAnd).ToString());
            TreeNode condfact2 = (TreeNode)Visit(context.condFact(i));
            arreglo[count] = and;
            arreglo[count + 1] = condfact2;
            count += 2;
            iAnd++;
        }
        TreeNode final = new TreeNode("CondTerm", arreglo);
        return final; 
    }

	
    public virtual object VisitConstDeclAST([NotNull] Parser1.ConstDeclASTContext context) { 
        TreeNode constante = new TreeNode(context.CONSTANTE().ToString());
        TreeNode type = (TreeNode)Visit(context.type());
        TreeNode ident = new TreeNode(context.IDENT().ToString());
        TreeNode asign = new TreeNode(context.ASIGN().ToString());
        TreeNode[] arreglo = new TreeNode[4];
        arreglo[0] = constante;
        arreglo[1] = type;
        arreglo[2] = ident;
        arreglo[3] = asign;

        int cont = 4;

        if (context.NUMBER() != null)
        {
            TreeNode number = new TreeNode(context.NUMBER().ToString());
            arreglo[cont] = number;
            cont++;
        }
        else if (context.CharConst() != null)
        {
            TreeNode charconst = new TreeNode(context.CharConst().ToString());
            arreglo[cont] = charconst;
            cont++;
        }
        TreeNode pycoma = new TreeNode(context.PyCOMA().ToString());
        arreglo[cont] = pycoma;
        TreeNode final = new TreeNode("ConstDecl", arreglo);
        return final;
    }

	
    public virtual object VisitProgramAST([NotNull] Parser1.ProgramASTContext context) {
        TreeNode Clase = new TreeNode(context.CLASE().ToString());
        TreeNode Ident = new TreeNode(context.IDENT().ToString());
        TreeNode CD = new TreeNode(context.COR_DER().ToString());
        TreeNode CI = new TreeNode(context.COR_IZQ().ToString());

        int largo = 4;
        //estimar el tamaño del arreglo a usar conociendo si vienen datos en dichas variables o no
        if (context.constDecl()!=null){largo++;}
        else if (context.varDecl() != null){largo++;}
        else if (context.classDecl() != null) { largo++;}
        
        TreeNode[] arreglo = new TreeNode[largo];
        arreglo[0] = Clase;
        arreglo[1] = Ident;
        int cont = 2;//estado actual de posición del arreglo

        //recorrer las variables en un ciclo porque se ejecutan una o más veces
        if (context.constDecl() != null) {
            for (int i = 0; i <= context.constDecl().Count(); i++)
            {
                arreglo[cont] = (TreeNode)Visit(context.constDecl(i));
                cont++;
            }
        }
        else if (context.varDecl() != null) {
            for (int i = 0; i <= context.varDecl().Count(); i++)
            {
                arreglo[cont] = (TreeNode)Visit(context.varDecl(i));
                cont++;
            }
        }
        else if (context.classDecl() != null) {
            for (int i = 0; i <= context.classDecl().Count(); i++)
            {
                arreglo[cont] = (TreeNode)Visit(context.classDecl(i));
                cont++;
            }
        }

        arreglo[cont] = CD; //lave derecha
        for (int i = 0; i <= context.methodDecl().Count(); i++)
        {
            arreglo[cont] = (TreeNode)Visit(context.methodDecl(i));
            cont++;
        }
        arreglo[cont] = CI;
        TreeNode final = new TreeNode("Program", arreglo);
        treeview.Nodes.Add(final);
        return final; //en caso de ERROR cambiar a null
    }

	
    public virtual object VisitMethodDeclAST([NotNull] Parser1.MethodDeclASTContext context) {
        int largo = 0;
        if (context.type() != null) { largo++; }
        if (context.varDecl() != null) { largo++; }
        TreeNode voids = new TreeNode(context.VOID().ToString());
        TreeNode ident = new TreeNode(context.IDENT().ToString());
        TreeNode PI = new TreeNode(context.PIZQ().ToString());
        TreeNode PD = new TreeNode(context.PDER().ToString());
        TreeNode block = new TreeNode(context.block().ToString());
        TreeNode[] arreglo;
        if (context.formPars() != null) //verificar si viene o no algo en el form pars
        {
            largo = 6 + context.varDecl().Count();
            arreglo = new TreeNode[largo];
            if (context.type() != null) //comprobar su viene un type, sino es void
            {
                TreeNode type = (TreeNode)Visit(context.type());
                TreeNode formpars = (TreeNode)Visit(context.formPars());
                arreglo[0] = type;
                arreglo[1] = ident;
                arreglo[2] = PI;
                arreglo[3] = formpars;
                arreglo[4] = PD;
                int count = 5;
                for (int i = 0; i <= context.varDecl().Count(); i++)
                {
                    TreeNode vardecl = (TreeNode)Visit(context.varDecl(i));
                    arreglo[count] = vardecl;
                    count++;
                }
                arreglo[count] = block;
            }
            else
            {
                TreeNode formpars = (TreeNode)Visit(context.formPars());
                arreglo[0] = voids;
                arreglo[1] = ident;
                arreglo[2] = PI;
                arreglo[3] = formpars;
                arreglo[4] = PD;
                int count = 5;
                for (int i = 0; i <= context.varDecl().Count(); i++)
                {
                    TreeNode vardecl = (TreeNode)Visit(context.varDecl(i));
                    arreglo[count] = vardecl;
                    count++;
                }
                arreglo[count] = block;
            }
        }
        else
        {
            largo = 6 + context.varDecl().Count();
            arreglo = new TreeNode[largo];
            if (context.type() != null)
            {
                TreeNode type = (TreeNode)Visit(context.type());
                arreglo[0] = type;
                arreglo[1] = ident;
                arreglo[2] = PI;
                arreglo[3] = PD;
                int count = 4;
                for (int i = 0; i <= context.varDecl().Count(); i++)
                {
                    TreeNode vardecl = (TreeNode)Visit(context.varDecl(i));
                    arreglo[count] = vardecl;
                    count++;
                }
                arreglo[count] = block;
            }
            else
            {
                arreglo[0] = voids;
                arreglo[1] = ident;
                arreglo[2] = PI;
                arreglo[3] = PD;
                int count = 4;
                for (int i = 0; i <= context.varDecl().Count(); i++)
                {
                    TreeNode vardecl = (TreeNode)Visit(context.varDecl(i));
                    arreglo[count] = vardecl;
                    count++;
                }
                arreglo[count] = block;
            }
        }
        TreeNode final = new TreeNode("MethodDecl", arreglo);
        return arreglo;
    }

	
    public virtual object VisitTypeAST([NotNull] Parser1.TypeASTContext context) {
        TreeNode ident = new TreeNode(context.IDENT().ToString());
        TreeNode[] arreglo;
        if (context.PCUADRADO_IZQ() != null) //comprobar si viene llaves o no (0/1)
        {
            TreeNode PI = new TreeNode(context.PCUADRADO_IZQ().ToString());
            TreeNode PD = new TreeNode(context.PCUADRADO_DER().ToString());
            arreglo = new TreeNode[] { ident, PI, PD };
        }
        else
        {
            arreglo = new TreeNode[] { ident };
        }
        TreeNode final = new TreeNode("Type", arreglo);
        return final;
    }

	
    public virtual object VisitFormParsAST([NotNull] Parser1.FormParsASTContext context) {
        TreeNode type1 = (TreeNode)Visit(context.type(0));
        TreeNode ident1 = new TreeNode(context.IDENT(0).ToString());
        int largo = 2 + context.COMA().Count() + context.type().Count() + context.IDENT().Count();
        TreeNode[] arreglo = new TreeNode[largo];
        arreglo[0] = type1;
        arreglo[1] = ident1;
        int count = 2;
        for (int i = 1; i <= context.type().Count(); i++)
        {
            TreeNode coma = new TreeNode(context.COMA(i).ToString());
            TreeNode type2 = (TreeNode)Visit(context.type(i));
            TreeNode ident2 = new TreeNode(context.IDENT(i).ToString());
            arreglo[count] = coma;
            arreglo[count + 1] = type2;
            count++;
            arreglo[count + 1] = ident2;
            count++;
        }
        TreeNode final = new TreeNode("FormPars", arreglo);
        return final;
    }

	
    public virtual object VisitActParsAST([NotNull] Parser1.ActParsASTContext context) {
        TreeNode expr1 = (TreeNode)Visit(context.expr(0));
        int largo = context.COMA().Count() + context.expr().Count();
        TreeNode[] arreglo = new TreeNode[largo];
        arreglo[0] = expr1;
        int count = 1; //contador del arreglo
        int icoma = 0; //contador para coma
        for (int i = 1; i <= context.expr().Count(); i++)
        {
            TreeNode coma = new TreeNode(context.COMA(icoma).ToString());
            TreeNode expr2 = (TreeNode)Visit(context.expr(i));
            arreglo[count] = coma;
            arreglo[count + 1] = expr2;
            count += 2;
            icoma++;
        }
        TreeNode final = new TreeNode("Actpars", arreglo);
        return final; 
    }

	
    public virtual object VisitDesignatorAST([NotNull] Parser1.DesignatorASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitCondFactAST([NotNull] Parser1.CondFactASTContext context) {
        TreeNode expr1 = (TreeNode)Visit(context.expr(0));
        TreeNode relop = (TreeNode)Visit(context.relop());
        TreeNode expr2 = (TreeNode)Visit(context.expr(1));
        TreeNode[] arreglo = new TreeNode[] { expr1, relop, expr2 };
        TreeNode final = new TreeNode("Condfact", arreglo);
        return final; 
    }

	
    public virtual object VisitConditionAST([NotNull] Parser1.ConditionASTContext context) { 
        TreeNode condterm1 = (TreeNode)Visit(context.condTerm(0));
        int largo = context.O().Count() + context.condTerm().Count();
        TreeNode[] arreglo = new TreeNode[largo];
        arreglo[0] = condterm1;
        int count = 1; //contador del arreglo
        int iOr = 0; //contador para Or
        for (int i = 1; i <= context.condTerm().Count(); i++)
        {
            TreeNode Or = new TreeNode(context.O(iOr).ToString());
            TreeNode condterm2 = (TreeNode)Visit(context.condTerm(i));
            arreglo[count] = Or;
            arreglo[count + 1] = condterm2;
            count += 2;
            iOr++;
        }
        TreeNode final = new TreeNode("Condition", arreglo);
        return final; 
    }

	
    public virtual object VisitReadStatAST([NotNull] Parser1.ReadStatASTContext context) {
        TreeNode read = new TreeNode(context.READ().ToString());
        TreeNode PI = new TreeNode(context.PIZQ().ToString());
        TreeNode designator = (TreeNode)Visit(context.designator());
        TreeNode PD = new TreeNode(context.PDER().ToString());
        TreeNode pycoma = new TreeNode(context.PyCOMA().ToString());
        TreeNode[] arreglo = new TreeNode[] { read, PI, designator, PD, pycoma };
        TreeNode final = new TreeNode("Statement", arreglo);
        return final; 
    }


    public virtual object VisitReturnStatAST([NotNull] Parser1.ReturnStatASTContext context) {
        TreeNode returns = new TreeNode(context.RETURN().ToString());
        TreeNode pycoma = new TreeNode(context.PyCOMA().ToString());
        TreeNode[] arreglo;
        if (context.expr() != null)
        {
            TreeNode expr = (TreeNode)Visit(context.expr());
            arreglo = new TreeNode[3];
            arreglo[0] = returns;
            arreglo[1] = expr;
            arreglo[2] = pycoma;
        }
        else
        {
            arreglo = new TreeNode[2];
            arreglo[0] = returns;
            arreglo[1] = pycoma;
        }
        TreeNode final = new TreeNode("Statement", arreglo);
        return final; 
    }


    public virtual object VisitPyStatAST([NotNull] Parser1.PyStatASTContext context) {
        TreeNode pycoma = new TreeNode(context.PyCOMA().ToString());
        TreeNode[] arreglo = new TreeNode[] { pycoma };
        TreeNode final = new TreeNode("Statement", arreglo);
        return final; 
    }

	
    public virtual object VisitWhileStatAST([NotNull] Parser1.WhileStatASTContext context) {
        TreeNode ciclo_while = new TreeNode(context.CICLO_WHILE().ToString());
        TreeNode PI = new TreeNode(context.PIZQ().ToString());
        TreeNode condition = (TreeNode)Visit(context.condition());
        TreeNode PD = new TreeNode(context.PDER().ToString());
        TreeNode statement = (TreeNode)Visit(context.statement());
        TreeNode[] arreglo = new TreeNode[]{ ciclo_while, PI, condition, PD, statement };
        TreeNode final = new TreeNode("Statement", arreglo);
        return final; 
    }


    public virtual object VisitWriteStatAST([NotNull] Parser1.WriteStatASTContext context) {
        TreeNode write = new TreeNode(context.WRITE().ToString());
        TreeNode PI = new TreeNode(context.PIZQ().ToString());
        TreeNode expr = (TreeNode)Visit(context.expr());
        TreeNode PD = new TreeNode(context.PDER().ToString());
        TreeNode pycoma = new TreeNode(context.PyCOMA().ToString());
        TreeNode[] arreglo;
        if (context.NUMBER() != null)
        {
            TreeNode number = new TreeNode(context.NUMBER().ToString());
            TreeNode coma = new TreeNode(context.COMA().ToString());
            arreglo = new TreeNode[] { write, PI, expr, coma, number, PD, pycoma };
        }
        else
        {
            arreglo = new TreeNode[] { write, PI, expr, PD, pycoma };
        }
        TreeNode final = new TreeNode("Statement", arreglo);
        return final; 
    }

	
    public virtual object VisitForeachStatAST([NotNull] Parser1.ForeachStatASTContext context) {
        TreeNode ciclo_foreach = new TreeNode(context.CICLO_FOREACH().ToString());
        TreeNode PI = new TreeNode(context.PIZQ().ToString());
        TreeNode type = (TreeNode)Visit(context.type());
        TreeNode ident = new TreeNode(context.IDENT().ToString());
        TreeNode ins = new TreeNode(context.IN().ToString());
        TreeNode expr = (TreeNode)Visit(context.expr());
        TreeNode PD = new TreeNode(context.PDER().ToString());
        TreeNode statement = (TreeNode)Visit(context.statement());
        TreeNode[] arreglo = new TreeNode[] { ciclo_foreach, PI, type, ident, ins, expr, PD, statement };
        TreeNode final = new TreeNode("Statement", arreglo);
        return final;
    }

	
    public virtual object VisitDesignatorStatAST([NotNull] Parser1.DesignatorStatASTContext context) {
        TreeNode designator = (TreeNode)Visit(context.designator());
        TreeNode pycoma = new TreeNode(context.PyCOMA().ToString());
        TreeNode[] arreglo = new TreeNode[]{};
        if (context.ASIGN() != null)
        {
            TreeNode expr = (TreeNode)Visit(context.expr());
            TreeNode asign = new TreeNode(context.ASIGN().ToString());
            arreglo[0] = designator;
            arreglo[1] = asign;
            arreglo[2] = expr;
            arreglo[3] = pycoma;
        }
        else if (context.PIZQ()!=null)
        {
            if (context.actPars() != null) //comprobar si viene o no un actPars
            {
                TreeNode PI = new TreeNode(context.PIZQ().ToString());
                TreeNode actpars = (TreeNode)Visit(context.actPars());
                TreeNode PD = new TreeNode(context.PDER().ToString());
                arreglo[0] = designator;
                arreglo[1] = PI;
                arreglo[2] = actpars;
                arreglo[3] = PD;
                arreglo[4] = pycoma;
            }else{
                TreeNode PI = new TreeNode(context.PIZQ().ToString());
                TreeNode PD = new TreeNode(context.PDER().ToString());
                arreglo[0] = designator;
                arreglo[1] = PI;
                arreglo[2] = PD;
                arreglo[3] = pycoma;
            }
        }
        else if(context.INCRE()!=null){
            TreeNode incre = new TreeNode(context.INCRE().ToString());
            arreglo[0] = designator;
            arreglo[1] = incre;
            arreglo[2] = pycoma;
        }
        else if(context.DECRE()!=null){
            TreeNode decre = new TreeNode(context.DECRE().ToString());
            arreglo[0] = designator;
            arreglo[1] = decre;
            arreglo[2] = pycoma;
        }
        TreeNode final = new TreeNode("Statement", arreglo);
        return final;
    }

	
    public virtual object VisitIfStatAST([NotNull] Parser1.IfStatASTContext context) {
        TreeNode cond_if = new TreeNode(context.CONDICION_IF().ToString());
        TreeNode PI = new TreeNode(context.PIZQ().ToString());
        TreeNode condition = (TreeNode)Visit(context.condition());
        TreeNode PD = new TreeNode(context.PDER().ToString());
        TreeNode statement1 = (TreeNode)Visit(context.statement(0));
        TreeNode[] arreglo;
        if (context.CONDICION_ELSE() != null) //puede o no venir la condición else
        {
            TreeNode cond_else = new TreeNode(context.CONDICION_ELSE().ToString());
            TreeNode statement2 = (TreeNode)Visit(context.statement(1)); //como viene o no viene y solo 1 vez se usa el 1 y no un ciclo
            arreglo = new TreeNode[] { cond_if, PI, condition, PD, statement1, cond_else, statement2 };
        }
        arreglo = new TreeNode[] { cond_if, PI, condition, PD, statement1};
        TreeNode final = new TreeNode("statement", arreglo);
        return final;
    }


    public virtual object VisitForStatAST([NotNull] Parser1.ForStatASTContext context) {
        TreeNode ciclo_for = new TreeNode(context.CICLO_FOR().ToString());
        TreeNode PI = new TreeNode(context.PIZQ().ToString());
        TreeNode expr = (TreeNode)Visit(context.expr());
        TreeNode pycoma = new TreeNode(context.PyCOMA().ToString());
        TreeNode PD = new TreeNode(context.PDER().ToString());
        TreeNode statement2 = (TreeNode)Visit(context.statement(1));
        TreeNode[] arreglo;
        if (context.condition() != null) //existe condición
        {
            TreeNode condition = (TreeNode)Visit(context.condition());
            if (context.statement() != null) //existe un statement
            {
                arreglo = new TreeNode[9];
                TreeNode statement1 = (TreeNode)Visit(context.statement(0));
                arreglo[0] = ciclo_for;
                arreglo[1] = PI;
                arreglo[2] = expr;
                arreglo[3] = pycoma;
                arreglo[4] = condition;
                arreglo[5] = pycoma;
                arreglo[6] = statement1;
                arreglo[7] = PD;
                arreglo[8] = statement2;
            }
            else
            {
                arreglo = new TreeNode[8];
                TreeNode statement1 = (TreeNode)Visit(context.statement(0));
                arreglo[0] = ciclo_for;
                arreglo[1] = PI;
                arreglo[2] = expr;
                arreglo[3] = pycoma;
                arreglo[4] = condition;
                arreglo[5] = pycoma;
                arreglo[6] = PD;
                arreglo[7] = statement2;
            }

        }
        else
        {
            if (context.statement() != null) //existe un statement
            {
                arreglo = new TreeNode[8];
                TreeNode statement1 = (TreeNode)Visit(context.statement(0));
                arreglo[0] = ciclo_for;
                arreglo[1] = PI;
                arreglo[2] = expr;
                arreglo[3] = pycoma;
                arreglo[4] = pycoma;
                arreglo[5] = statement1;
                arreglo[6] = PD;
                arreglo[7] = statement2;
            }
            else
            {
                arreglo = new TreeNode[7];
                TreeNode statement1 = (TreeNode)Visit(context.statement(0));
                arreglo[0] = ciclo_for;
                arreglo[1] = PI;
                arreglo[2] = expr;
                arreglo[3] = pycoma;
                arreglo[4] = pycoma;
                arreglo[5] = PD;
                arreglo[6] = statement2;
            }

        }
        TreeNode final = new TreeNode("Statement", arreglo);
        return final; 
    }

	
    public virtual object VisitBlockStatAST([NotNull] Parser1.BlockStatASTContext context) {
        TreeNode block = (TreeNode)Visit(context.block());
        TreeNode[] arreglo = new TreeNode[] { block };
        TreeNode final = new TreeNode("Statement", arreglo);
        return final; 
    }

	
    public virtual object VisitBreakStatAST([NotNull] Parser1.BreakStatASTContext context) {
        TreeNode breaks = new TreeNode(context.BREAK().ToString());
        TreeNode pycoma = new TreeNode(context.PyCOMA().ToString());
        TreeNode[] arreglo = new TreeNode[] { breaks,pycoma};
        TreeNode final = new TreeNode("Statement", arreglo);
        return final;
    }

	
    public virtual object VisitBlockAST([NotNull] Parser1.BlockASTContext context) {
        TreeNode CD = new TreeNode(context.COR_DER().ToString());
        TreeNode CI = new TreeNode(context.COR_IZQ().ToString());
        int largo = 2 + context.statement().Count();
        TreeNode[] arreglo = new TreeNode[largo];
        arreglo[0] = CD;
        int count = 1;
        for (int i = 0; i <= context.statement().Count(); i++)
        {
            TreeNode statement = (TreeNode)Visit(context.statement(i));
            arreglo[count] = statement;
            count++;
        }
        arreglo[0] = CI;
        TreeNode final = new TreeNode("Block", arreglo);
        return final; 
    }

	
    public virtual object VisitExprAST([NotNull] Parser1.ExprASTContext context) {
        if (context.RESTA() != null)
        {
            TreeNode resta = new TreeNode()//áquí
        }
        return VisitChildren(context); 
    }

	
    public virtual object VisitTermAST([NotNull] Parser1.TermASTContext context) {
        TreeNode factor1 = (TreeNode)Visit(context.factor(0));
        int largo = context.mulop().Count() + context.factor().Count();
        TreeNode[] arreglo = new TreeNode[largo];
        arreglo[0] = factor1;
        int count = 1; //contador del arreglo
        int iMulop = 0; //contador para mulop
        for (int i = 1; i <= context.factor().Count(); i++)
        {
            TreeNode mulop = new TreeNode(context.mulop(iMulop).ToString());
            TreeNode factor2 = (TreeNode)Visit(context.factor(i));
            arreglo[count] = mulop;
            arreglo[count + 1] = factor2;
            count += 2;
            iMulop++;
        }
        TreeNode final = new TreeNode("Factor", arreglo);
        return final; 
    }

	
    public virtual object VisitExprFactorAST([NotNull] Parser1.ExprFactorASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitTruefalseFactorAST([NotNull] Parser1.TruefalseFactorASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitNewFactorAST([NotNull] Parser1.NewFactorASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitDesignatorFactorAST([NotNull] Parser1.DesignatorFactorASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitNumberFactorAST([NotNull] Parser1.NumberFactorASTContext context) { return VisitChildren(context); }


    public virtual object VisitCharconstFactorAST([NotNull] Parser1.CharconstFactorASTContext context) { return VisitChildren(context); }

	
    public virtual object VisitVarDeclAST([NotNull] Parser1.VarDeclASTContext context) {
        TreeNode type = (TreeNode)Visit(context.type());
        TreeNode ident = new TreeNode(context.IDENT(0).ToString());
        TreeNode pycoma = new TreeNode(context.PyCOMA().ToString());
        int largo = 3+context.IDENT().Count() + context.COMA().Count();
        TreeNode[] arreglo = new TreeNode[largo];
        arreglo[0] = type;
        arreglo[1] = ident;
        int cont = 2;
        int i2 = 0;
        for (int i = 1; i <= context.IDENT().Count(); i++)
        {
            TreeNode coma = new TreeNode(context.COMA(i2).ToString());
            TreeNode ident2 = new TreeNode(context.IDENT(i).ToString());
            arreglo[cont] = coma;
            arreglo[cont + 1] = ident2;
            cont++;
            i2+=2;
        }
        arreglo[cont] = pycoma;
        TreeNode final = new TreeNode("varDecl", arreglo);
        return final;
    }

	
    public virtual object VisitProgram([NotNull] Parser1.ProgramContext context) { return VisitChildren(context); }

	
    public virtual object VisitConstDecl([NotNull] Parser1.ConstDeclContext context) { return VisitChildren(context); }

	
    public virtual object VisitVarDecl([NotNull] Parser1.VarDeclContext context) { return VisitChildren(context); }

	
    public virtual object VisitClassDecl([NotNull] Parser1.ClassDeclContext context) { return VisitChildren(context); }

	
    public virtual object VisitMethodDecl([NotNull] Parser1.MethodDeclContext context) { return VisitChildren(context); }

	
    public virtual object VisitFormPars([NotNull] Parser1.FormParsContext context) { return VisitChildren(context); }

	
    public virtual object VisitType([NotNull] Parser1.TypeContext context) { return VisitChildren(context); }

	
    public virtual object VisitStatement([NotNull] Parser1.StatementContext context) { return VisitChildren(context); }

	
    public virtual object VisitBlock([NotNull] Parser1.BlockContext context) { return VisitChildren(context); }

	
    public virtual object VisitActPars([NotNull] Parser1.ActParsContext context) { return VisitChildren(context); }

	
    public virtual object VisitCondition([NotNull] Parser1.ConditionContext context) { return VisitChildren(context); }

	
    public virtual object VisitCondTerm([NotNull] Parser1.CondTermContext context) { return VisitChildren(context); }

	
    public virtual object VisitCondFact([NotNull] Parser1.CondFactContext context) { return VisitChildren(context); }

	
    public virtual object VisitExpr([NotNull] Parser1.ExprContext context) { return VisitChildren(context); }

	
    public virtual object VisitTerm([NotNull] Parser1.TermContext context) { return VisitChildren(context); }

	
    public virtual object VisitFactor([NotNull] Parser1.FactorContext context) { return VisitChildren(context); }

	
    public virtual object VisitDesignator([NotNull] Parser1.DesignatorContext context) { return VisitChildren(context); }

	
    public virtual object VisitRelop([NotNull] Parser1.RelopContext context) { return VisitChildren(context); }

	
    public virtual object VisitAddop([NotNull] Parser1.AddopContext context) { return VisitChildren(context); }

	
    public virtual object VisitMulop([NotNull] Parser1.MulopContext context) { return VisitChildren(context); }


}