//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\USUARIO1\Desktop\MiniCSharp-Parte1\AnalizadorSintactico\Parser1.g4 by ANTLR 4.5-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AnalizadorSintactico {

using System;

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="Parser1"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
[System.CLSCompliant(false)]
public interface IParser1Visitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>classDeclAST</c>
	/// labeled alternative in <see cref="Parser1.classDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassDeclAST([NotNull] Parser1.ClassDeclASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>sumaAddopAST</c>
	/// labeled alternative in <see cref="Parser1.addop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSumaAddopAST([NotNull] Parser1.SumaAddopASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>restaAddopAST</c>
	/// labeled alternative in <see cref="Parser1.addop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRestaAddopAST([NotNull] Parser1.RestaAddopASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>condTermAST</c>
	/// labeled alternative in <see cref="Parser1.condTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondTermAST([NotNull] Parser1.CondTermASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>constDeclAST</c>
	/// labeled alternative in <see cref="Parser1.constDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstDeclAST([NotNull] Parser1.ConstDeclASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>programAST</c>
	/// labeled alternative in <see cref="Parser1.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgramAST([NotNull] Parser1.ProgramASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>methodDeclAST</c>
	/// labeled alternative in <see cref="Parser1.methodDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodDeclAST([NotNull] Parser1.MethodDeclASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>typeAST</c>
	/// labeled alternative in <see cref="Parser1.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeAST([NotNull] Parser1.TypeASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>mayorigualRelopAST</c>
	/// labeled alternative in <see cref="Parser1.relop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMayorigualRelopAST([NotNull] Parser1.MayorigualRelopASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>mayorRelopAST</c>
	/// labeled alternative in <see cref="Parser1.relop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMayorRelopAST([NotNull] Parser1.MayorRelopASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>menorRelopAST</c>
	/// labeled alternative in <see cref="Parser1.relop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMenorRelopAST([NotNull] Parser1.MenorRelopASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>diferenteRelopAST</c>
	/// labeled alternative in <see cref="Parser1.relop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDiferenteRelopAST([NotNull] Parser1.DiferenteRelopASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>menorigualRelopAST</c>
	/// labeled alternative in <see cref="Parser1.relop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMenorigualRelopAST([NotNull] Parser1.MenorigualRelopASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>comparacionRelopAST</c>
	/// labeled alternative in <see cref="Parser1.relop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComparacionRelopAST([NotNull] Parser1.ComparacionRelopASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>formParsAST</c>
	/// labeled alternative in <see cref="Parser1.formPars"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFormParsAST([NotNull] Parser1.FormParsASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>actParsAST</c>
	/// labeled alternative in <see cref="Parser1.actPars"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitActParsAST([NotNull] Parser1.ActParsASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>designatorAST</c>
	/// labeled alternative in <see cref="Parser1.designator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDesignatorAST([NotNull] Parser1.DesignatorASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>condFactAST</c>
	/// labeled alternative in <see cref="Parser1.condFact"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondFactAST([NotNull] Parser1.CondFactASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>conditionAST</c>
	/// labeled alternative in <see cref="Parser1.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConditionAST([NotNull] Parser1.ConditionASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>divMulopAST</c>
	/// labeled alternative in <see cref="Parser1.mulop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDivMulopAST([NotNull] Parser1.DivMulopASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>divmodMulopAST</c>
	/// labeled alternative in <see cref="Parser1.mulop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDivmodMulopAST([NotNull] Parser1.DivmodMulopASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>mulMulopAST</c>
	/// labeled alternative in <see cref="Parser1.mulop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMulMulopAST([NotNull] Parser1.MulMulopASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>readStatAST</c>
	/// labeled alternative in <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReadStatAST([NotNull] Parser1.ReadStatASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>returnStatAST</c>
	/// labeled alternative in <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnStatAST([NotNull] Parser1.ReturnStatASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>pyStatAST</c>
	/// labeled alternative in <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPyStatAST([NotNull] Parser1.PyStatASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>whileStatAST</c>
	/// labeled alternative in <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileStatAST([NotNull] Parser1.WhileStatASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>writeStatAST</c>
	/// labeled alternative in <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWriteStatAST([NotNull] Parser1.WriteStatASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>foreachStatAST</c>
	/// labeled alternative in <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForeachStatAST([NotNull] Parser1.ForeachStatASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>designatorStatAST</c>
	/// labeled alternative in <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDesignatorStatAST([NotNull] Parser1.DesignatorStatASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ifStatAST</c>
	/// labeled alternative in <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStatAST([NotNull] Parser1.IfStatASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>forStatAST</c>
	/// labeled alternative in <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForStatAST([NotNull] Parser1.ForStatASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>blockStatAST</c>
	/// labeled alternative in <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockStatAST([NotNull] Parser1.BlockStatASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>breakStatAST</c>
	/// labeled alternative in <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBreakStatAST([NotNull] Parser1.BreakStatASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>blockAST</c>
	/// labeled alternative in <see cref="Parser1.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockAST([NotNull] Parser1.BlockASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>exprAST</c>
	/// labeled alternative in <see cref="Parser1.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprAST([NotNull] Parser1.ExprASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>termAST</c>
	/// labeled alternative in <see cref="Parser1.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTermAST([NotNull] Parser1.TermASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>exprFactorAST</c>
	/// labeled alternative in <see cref="Parser1.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprFactorAST([NotNull] Parser1.ExprFactorASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>truefalseFactorAST</c>
	/// labeled alternative in <see cref="Parser1.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTruefalseFactorAST([NotNull] Parser1.TruefalseFactorASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>newFactorAST</c>
	/// labeled alternative in <see cref="Parser1.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNewFactorAST([NotNull] Parser1.NewFactorASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>designatorFactorAST</c>
	/// labeled alternative in <see cref="Parser1.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDesignatorFactorAST([NotNull] Parser1.DesignatorFactorASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>numberFactorAST</c>
	/// labeled alternative in <see cref="Parser1.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumberFactorAST([NotNull] Parser1.NumberFactorASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>charconstFactorAST</c>
	/// labeled alternative in <see cref="Parser1.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCharconstFactorAST([NotNull] Parser1.CharconstFactorASTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>varDeclAST</c>
	/// labeled alternative in <see cref="Parser1.varDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarDeclAST([NotNull] Parser1.VarDeclASTContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] Parser1.ProgramContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.constDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstDecl([NotNull] Parser1.ConstDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.varDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarDecl([NotNull] Parser1.VarDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.classDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassDecl([NotNull] Parser1.ClassDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.methodDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodDecl([NotNull] Parser1.MethodDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.formPars"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFormPars([NotNull] Parser1.FormParsContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] Parser1.TypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] Parser1.StatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] Parser1.BlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.actPars"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitActPars([NotNull] Parser1.ActParsContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondition([NotNull] Parser1.ConditionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.condTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondTerm([NotNull] Parser1.CondTermContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.condFact"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondFact([NotNull] Parser1.CondFactContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] Parser1.ExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTerm([NotNull] Parser1.TermContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactor([NotNull] Parser1.FactorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.designator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDesignator([NotNull] Parser1.DesignatorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.relop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelop([NotNull] Parser1.RelopContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.addop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddop([NotNull] Parser1.AddopContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Parser1.mulop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMulop([NotNull] Parser1.MulopContext context);
}
} // namespace AnalizadorSintactico
