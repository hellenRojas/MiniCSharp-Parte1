//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\users\usuario1\documents\visual studio 2013\Projects\AnalizadorSintactico\AnalizadorSintactico\Parser1.g4 by ANTLR 4.5-SNAPSHOT

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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="Parser1"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
[System.CLSCompliant(false)]
public interface IParser1Listener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>exprsAST</c>
	/// labeled alternative in <see cref="Parser1.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprsAST([NotNull] Parser1.ExprsASTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprsAST</c>
	/// labeled alternative in <see cref="Parser1.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprsAST([NotNull] Parser1.ExprsASTContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>epsStatAST</c>
	/// labeled alternative in <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEpsStatAST([NotNull] Parser1.EpsStatASTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>epsStatAST</c>
	/// labeled alternative in <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEpsStatAST([NotNull] Parser1.EpsStatASTContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>asignStatAST</c>
	/// labeled alternative in <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAsignStatAST([NotNull] Parser1.AsignStatASTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>asignStatAST</c>
	/// labeled alternative in <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAsignStatAST([NotNull] Parser1.AsignStatASTContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>exprStatAST</c>
	/// labeled alternative in <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprStatAST([NotNull] Parser1.ExprStatASTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprStatAST</c>
	/// labeled alternative in <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprStatAST([NotNull] Parser1.ExprStatASTContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>idlistsAST</c>
	/// labeled alternative in <see cref="Parser1.idlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdlistsAST([NotNull] Parser1.IdlistsASTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>idlistsAST</c>
	/// labeled alternative in <see cref="Parser1.idlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdlistsAST([NotNull] Parser1.IdlistsASTContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>statsAST</c>
	/// labeled alternative in <see cref="Parser1.statements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatsAST([NotNull] Parser1.StatsASTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>statsAST</c>
	/// labeled alternative in <see cref="Parser1.statements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatsAST([NotNull] Parser1.StatsASTContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>termsAST</c>
	/// labeled alternative in <see cref="Parser1.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTermsAST([NotNull] Parser1.TermsASTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>termsAST</c>
	/// labeled alternative in <see cref="Parser1.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTermsAST([NotNull] Parser1.TermsASTContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>sinDeclAST</c>
	/// labeled alternative in <see cref="Parser1.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSinDeclAST([NotNull] Parser1.SinDeclASTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>sinDeclAST</c>
	/// labeled alternative in <see cref="Parser1.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSinDeclAST([NotNull] Parser1.SinDeclASTContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>conDeclAST</c>
	/// labeled alternative in <see cref="Parser1.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConDeclAST([NotNull] Parser1.ConDeclASTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>conDeclAST</c>
	/// labeled alternative in <see cref="Parser1.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConDeclAST([NotNull] Parser1.ConDeclASTContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>exprFactAST</c>
	/// labeled alternative in <see cref="Parser1.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprFactAST([NotNull] Parser1.ExprFactASTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprFactAST</c>
	/// labeled alternative in <see cref="Parser1.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprFactAST([NotNull] Parser1.ExprFactASTContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>idFactAST</c>
	/// labeled alternative in <see cref="Parser1.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdFactAST([NotNull] Parser1.IdFactASTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>idFactAST</c>
	/// labeled alternative in <see cref="Parser1.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdFactAST([NotNull] Parser1.IdFactASTContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>numFactAST</c>
	/// labeled alternative in <see cref="Parser1.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumFactAST([NotNull] Parser1.NumFactASTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>numFactAST</c>
	/// labeled alternative in <see cref="Parser1.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumFactAST([NotNull] Parser1.NumFactASTContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>strFactAST</c>
	/// labeled alternative in <see cref="Parser1.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStrFactAST([NotNull] Parser1.StrFactASTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>strFactAST</c>
	/// labeled alternative in <see cref="Parser1.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStrFactAST([NotNull] Parser1.StrFactASTContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>strDeclAST</c>
	/// labeled alternative in <see cref="Parser1.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStrDeclAST([NotNull] Parser1.StrDeclASTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>strDeclAST</c>
	/// labeled alternative in <see cref="Parser1.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStrDeclAST([NotNull] Parser1.StrDeclASTContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>intDeclAST</c>
	/// labeled alternative in <see cref="Parser1.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntDeclAST([NotNull] Parser1.IntDeclASTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>intDeclAST</c>
	/// labeled alternative in <see cref="Parser1.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntDeclAST([NotNull] Parser1.IntDeclASTContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>declsAST</c>
	/// labeled alternative in <see cref="Parser1.declarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclsAST([NotNull] Parser1.DeclsASTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>declsAST</c>
	/// labeled alternative in <see cref="Parser1.declarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclsAST([NotNull] Parser1.DeclsASTContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Parser1.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] Parser1.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Parser1.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] Parser1.ProgramContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Parser1.declarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclarations([NotNull] Parser1.DeclarationsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Parser1.declarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclarations([NotNull] Parser1.DeclarationsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Parser1.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclaration([NotNull] Parser1.DeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Parser1.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclaration([NotNull] Parser1.DeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Parser1.statements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatements([NotNull] Parser1.StatementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Parser1.statements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatements([NotNull] Parser1.StatementsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] Parser1.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Parser1.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] Parser1.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Parser1.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] Parser1.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Parser1.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] Parser1.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Parser1.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTerm([NotNull] Parser1.TermContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Parser1.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTerm([NotNull] Parser1.TermContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Parser1.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFactor([NotNull] Parser1.FactorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Parser1.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFactor([NotNull] Parser1.FactorContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Parser1.idlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdlist([NotNull] Parser1.IdlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Parser1.idlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdlist([NotNull] Parser1.IdlistContext context);
}
} // namespace AnalizadorSintactico
