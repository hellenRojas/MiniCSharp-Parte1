//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\usuario\Desktop\MiniCSharp-Parte1\AnalizadorSintactico\Parser1.g4 by ANTLR 4.5-SNAPSHOT

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

using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class Parser1 : Parser {
	public const int
		WS=1, NEWLINE=2, COMMMETBLOCK=3, COMMMET=4, INT=5, STRING=6, FLOAT=7, 
		BOOLEAN=8, VOID=9, CONDICION_IF=10, CONDICION_ELSE_IF=11, CONDICION_ELSE=12, 
		CICLO_WHILE=13, CICLO_FOR=14, BREAK=15, RETURN=16, READ=17, WRITE=18, 
		CLASE=19, NEW=20, CONSTANTE=21, PyCOMA=22, COMA=23, ASIGN=24, PIZQ=25, 
		PDER=26, SUMA=27, MUL=28, DIV=29, DIVMOD=30, COMPARACION=31, DIFERENTE=32, 
		MENOR=33, MENORIGUAL=34, MAYOR=35, MAYORIGUAL=36, O=37, Y=38, INCRE=39, 
		DECRE=40, PUNTO=41, PCUADRADO_DER=42, PCUADRADO_IZQ=43, COR_DER=44, COR_IZQ=45, 
		NUM=46, ID=47, STR=48, LQUOTE=49;
	public const int
		RULE_program = 0, RULE_declarations = 1, RULE_declaration = 2, RULE_statements = 3, 
		RULE_statement = 4, RULE_expression = 5, RULE_term = 6, RULE_factor = 7, 
		RULE_idlist = 8;
	public static readonly string[] ruleNames = {
		"program", "declarations", "declaration", "statements", "statement", "expression", 
		"term", "factor", "idlist"
	};

	private static readonly string[] _LiteralNames = {
		null, "' '", null, null, null, "'int'", "'string'", "'float'", "'boolean'", 
		"'void'", "'if'", "'else if'", "'else'", "'while'", "'for'", "'break'", 
		"'return'", "'read'", "'write'", "'class'", "'new'", "'const'", "';'", 
		"','", "'='", "'('", "')'", "'+'", "'*'", "'/'", "'%'", "'=='", "'!='", 
		"'<'", "'<='", "'>'", "'>='", "'||'", "'&&'", "'++'", "'--'", "'.'", "'['", 
		"']'", "'{'", "'}'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "WS", "NEWLINE", "COMMMETBLOCK", "COMMMET", "INT", "STRING", "FLOAT", 
		"BOOLEAN", "VOID", "CONDICION_IF", "CONDICION_ELSE_IF", "CONDICION_ELSE", 
		"CICLO_WHILE", "CICLO_FOR", "BREAK", "RETURN", "READ", "WRITE", "CLASE", 
		"NEW", "CONSTANTE", "PyCOMA", "COMA", "ASIGN", "PIZQ", "PDER", "SUMA", 
		"MUL", "DIV", "DIVMOD", "COMPARACION", "DIFERENTE", "MENOR", "MENORIGUAL", 
		"MAYOR", "MAYORIGUAL", "O", "Y", "INCRE", "DECRE", "PUNTO", "PCUADRADO_DER", 
		"PCUADRADO_IZQ", "COR_DER", "COR_IZQ", "NUM", "ID", "STR", "LQUOTE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Parser1.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public Parser1(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class ProgramContext : ParserRuleContext {
		public ProgramContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_program; } }
	 
		public ProgramContext() { }
		public virtual void CopyFrom(ProgramContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class SinDeclASTContext : ProgramContext {
		public StatementsContext statements() {
			return GetRuleContext<StatementsContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(Parser1.Eof, 0); }
		public SinDeclASTContext(ProgramContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.EnterSinDeclAST(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.ExitSinDeclAST(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IParser1Visitor<TResult> typedVisitor = visitor as IParser1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSinDeclAST(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ConDeclASTContext : ProgramContext {
		public DeclarationsContext declarations() {
			return GetRuleContext<DeclarationsContext>(0);
		}
		public StatementsContext statements() {
			return GetRuleContext<StatementsContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(Parser1.Eof, 0); }
		public ConDeclASTContext(ProgramContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.EnterConDeclAST(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.ExitConDeclAST(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IParser1Visitor<TResult> typedVisitor = visitor as IParser1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitConDeclAST(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgramContext program() {
		ProgramContext _localctx = new ProgramContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_program);
		try {
			State = 25;
			switch (_input.La(1)) {
			case INT:
			case STRING:
				_localctx = new ConDeclASTContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 18; declarations();
				State = 19; statements();
				State = 20; Match(Eof);
				}
				break;
			case Eof:
			case PyCOMA:
			case PIZQ:
			case NUM:
			case ID:
			case STR:
				_localctx = new SinDeclASTContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 22; statements();
				State = 23; Match(Eof);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DeclarationsContext : ParserRuleContext {
		public DeclarationsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declarations; } }
	 
		public DeclarationsContext() { }
		public virtual void CopyFrom(DeclarationsContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class DeclsASTContext : DeclarationsContext {
		public DeclarationContext[] declaration() {
			return GetRuleContexts<DeclarationContext>();
		}
		public DeclarationContext declaration(int i) {
			return GetRuleContext<DeclarationContext>(i);
		}
		public ITerminalNode[] PyCOMA() { return GetTokens(Parser1.PyCOMA); }
		public ITerminalNode PyCOMA(int i) {
			return GetToken(Parser1.PyCOMA, i);
		}
		public DeclsASTContext(DeclarationsContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.EnterDeclsAST(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.ExitDeclsAST(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IParser1Visitor<TResult> typedVisitor = visitor as IParser1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDeclsAST(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DeclarationsContext declarations() {
		DeclarationsContext _localctx = new DeclarationsContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_declarations);
		int _la;
		try {
			_localctx = new DeclsASTContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 27; declaration();
			State = 28; Match(PyCOMA);
			State = 34;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==INT || _la==STRING) {
				{
				{
				State = 29; declaration();
				State = 30; Match(PyCOMA);
				}
				}
				State = 36;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DeclarationContext : ParserRuleContext {
		public DeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declaration; } }
	 
		public DeclarationContext() { }
		public virtual void CopyFrom(DeclarationContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class StrDeclASTContext : DeclarationContext {
		public ITerminalNode STRING() { return GetToken(Parser1.STRING, 0); }
		public IdlistContext idlist() {
			return GetRuleContext<IdlistContext>(0);
		}
		public StrDeclASTContext(DeclarationContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.EnterStrDeclAST(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.ExitStrDeclAST(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IParser1Visitor<TResult> typedVisitor = visitor as IParser1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStrDeclAST(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IntDeclASTContext : DeclarationContext {
		public ITerminalNode INT() { return GetToken(Parser1.INT, 0); }
		public IdlistContext idlist() {
			return GetRuleContext<IdlistContext>(0);
		}
		public IntDeclASTContext(DeclarationContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.EnterIntDeclAST(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.ExitIntDeclAST(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IParser1Visitor<TResult> typedVisitor = visitor as IParser1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIntDeclAST(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DeclarationContext declaration() {
		DeclarationContext _localctx = new DeclarationContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_declaration);
		try {
			State = 41;
			switch (_input.La(1)) {
			case INT:
				_localctx = new IntDeclASTContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 37; Match(INT);
				State = 38; idlist();
				}
				break;
			case STRING:
				_localctx = new StrDeclASTContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 39; Match(STRING);
				State = 40; idlist();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatementsContext : ParserRuleContext {
		public StatementsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statements; } }
	 
		public StatementsContext() { }
		public virtual void CopyFrom(StatementsContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class StatsASTContext : StatementsContext {
		public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public ITerminalNode[] PyCOMA() { return GetTokens(Parser1.PyCOMA); }
		public ITerminalNode PyCOMA(int i) {
			return GetToken(Parser1.PyCOMA, i);
		}
		public StatsASTContext(StatementsContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.EnterStatsAST(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.ExitStatsAST(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IParser1Visitor<TResult> typedVisitor = visitor as IParser1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStatsAST(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatementsContext statements() {
		StatementsContext _localctx = new StatementsContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_statements);
		int _la;
		try {
			_localctx = new StatsASTContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 43; statement();
			State = 48;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==PyCOMA) {
				{
				{
				State = 44; Match(PyCOMA);
				State = 45; statement();
				}
				}
				State = 50;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatementContext : ParserRuleContext {
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
	 
		public StatementContext() { }
		public virtual void CopyFrom(StatementContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class EpsStatASTContext : StatementContext {
		public EpsStatASTContext(StatementContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.EnterEpsStatAST(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.ExitEpsStatAST(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IParser1Visitor<TResult> typedVisitor = visitor as IParser1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitEpsStatAST(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AsignStatASTContext : StatementContext {
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode ID() { return GetToken(Parser1.ID, 0); }
		public ITerminalNode ASIGN() { return GetToken(Parser1.ASIGN, 0); }
		public AsignStatASTContext(StatementContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.EnterAsignStatAST(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.ExitAsignStatAST(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IParser1Visitor<TResult> typedVisitor = visitor as IParser1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAsignStatAST(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ExprStatASTContext : StatementContext {
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ExprStatASTContext(StatementContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.EnterExprStatAST(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.ExitExprStatAST(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IParser1Visitor<TResult> typedVisitor = visitor as IParser1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExprStatAST(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_statement);
		try {
			State = 59;
			switch ( Interpreter.AdaptivePredict(_input,5,_ctx) ) {
			case 1:
				_localctx = new AsignStatASTContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 54;
				switch ( Interpreter.AdaptivePredict(_input,4,_ctx) ) {
				case 1:
					{
					State = 51; Match(ID);
					State = 52; Match(ASIGN);
					}
					break;

				case 2:
					{
					}
					break;
				}
				State = 56; expression();
				}
				break;

			case 2:
				_localctx = new ExprStatASTContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 57; expression();
				}
				break;

			case 3:
				_localctx = new EpsStatASTContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
	 
		public ExpressionContext() { }
		public virtual void CopyFrom(ExpressionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class ExprsASTContext : ExpressionContext {
		public TermContext[] term() {
			return GetRuleContexts<TermContext>();
		}
		public TermContext term(int i) {
			return GetRuleContext<TermContext>(i);
		}
		public ITerminalNode[] SUMA() { return GetTokens(Parser1.SUMA); }
		public ITerminalNode SUMA(int i) {
			return GetToken(Parser1.SUMA, i);
		}
		public ExprsASTContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.EnterExprsAST(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.ExitExprsAST(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IParser1Visitor<TResult> typedVisitor = visitor as IParser1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExprsAST(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		ExpressionContext _localctx = new ExpressionContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_expression);
		int _la;
		try {
			_localctx = new ExprsASTContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 61; term();
			State = 66;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==SUMA) {
				{
				{
				State = 62; Match(SUMA);
				State = 63; term();
				}
				}
				State = 68;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TermContext : ParserRuleContext {
		public TermContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_term; } }
	 
		public TermContext() { }
		public virtual void CopyFrom(TermContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class TermsASTContext : TermContext {
		public FactorContext[] factor() {
			return GetRuleContexts<FactorContext>();
		}
		public FactorContext factor(int i) {
			return GetRuleContext<FactorContext>(i);
		}
		public ITerminalNode[] MUL() { return GetTokens(Parser1.MUL); }
		public ITerminalNode MUL(int i) {
			return GetToken(Parser1.MUL, i);
		}
		public TermsASTContext(TermContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.EnterTermsAST(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.ExitTermsAST(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IParser1Visitor<TResult> typedVisitor = visitor as IParser1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTermsAST(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TermContext term() {
		TermContext _localctx = new TermContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_term);
		int _la;
		try {
			_localctx = new TermsASTContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 69; factor();
			State = 74;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==MUL) {
				{
				{
				State = 70; Match(MUL);
				State = 71; factor();
				}
				}
				State = 76;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FactorContext : ParserRuleContext {
		public FactorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_factor; } }
	 
		public FactorContext() { }
		public virtual void CopyFrom(FactorContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class ExprFactASTContext : FactorContext {
		public ITerminalNode PIZQ() { return GetToken(Parser1.PIZQ, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode PDER() { return GetToken(Parser1.PDER, 0); }
		public ExprFactASTContext(FactorContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.EnterExprFactAST(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.ExitExprFactAST(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IParser1Visitor<TResult> typedVisitor = visitor as IParser1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExprFactAST(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IdFactASTContext : FactorContext {
		public ITerminalNode ID() { return GetToken(Parser1.ID, 0); }
		public IdFactASTContext(FactorContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.EnterIdFactAST(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.ExitIdFactAST(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IParser1Visitor<TResult> typedVisitor = visitor as IParser1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIdFactAST(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NumFactASTContext : FactorContext {
		public ITerminalNode NUM() { return GetToken(Parser1.NUM, 0); }
		public NumFactASTContext(FactorContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.EnterNumFactAST(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.ExitNumFactAST(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IParser1Visitor<TResult> typedVisitor = visitor as IParser1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumFactAST(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class StrFactASTContext : FactorContext {
		public ITerminalNode STR() { return GetToken(Parser1.STR, 0); }
		public StrFactASTContext(FactorContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.EnterStrFactAST(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.ExitStrFactAST(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IParser1Visitor<TResult> typedVisitor = visitor as IParser1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStrFactAST(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FactorContext factor() {
		FactorContext _localctx = new FactorContext(_ctx, State);
		EnterRule(_localctx, 14, RULE_factor);
		try {
			State = 84;
			switch (_input.La(1)) {
			case PIZQ:
				_localctx = new ExprFactASTContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 77; Match(PIZQ);
				State = 78; expression();
				State = 79; Match(PDER);
				}
				break;
			case ID:
				_localctx = new IdFactASTContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 81; Match(ID);
				}
				break;
			case NUM:
				_localctx = new NumFactASTContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 82; Match(NUM);
				}
				break;
			case STR:
				_localctx = new StrFactASTContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 83; Match(STR);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IdlistContext : ParserRuleContext {
		public IdlistContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_idlist; } }
	 
		public IdlistContext() { }
		public virtual void CopyFrom(IdlistContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class IdlistsASTContext : IdlistContext {
		public ITerminalNode[] ID() { return GetTokens(Parser1.ID); }
		public ITerminalNode ID(int i) {
			return GetToken(Parser1.ID, i);
		}
		public ITerminalNode[] COMA() { return GetTokens(Parser1.COMA); }
		public ITerminalNode COMA(int i) {
			return GetToken(Parser1.COMA, i);
		}
		public IdlistsASTContext(IdlistContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.EnterIdlistsAST(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IParser1Listener typedListener = listener as IParser1Listener;
			if (typedListener != null) typedListener.ExitIdlistsAST(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IParser1Visitor<TResult> typedVisitor = visitor as IParser1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIdlistsAST(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IdlistContext idlist() {
		IdlistContext _localctx = new IdlistContext(_ctx, State);
		EnterRule(_localctx, 16, RULE_idlist);
		int _la;
		try {
			_localctx = new IdlistsASTContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 86; Match(ID);
			State = 91;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==COMA) {
				{
				{
				State = 87; Match(COMA);
				State = 88; Match(ID);
				}
				}
				State = 93;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x33\x61\x4\x2\t"+
		"\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t"+
		"\t\t\x4\n\t\n\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x5\x2\x1C\n\x2"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\a\x3#\n\x3\f\x3\xE\x3&\v\x3\x3\x4\x3\x4"+
		"\x3\x4\x3\x4\x5\x4,\n\x4\x3\x5\x3\x5\x3\x5\a\x5\x31\n\x5\f\x5\xE\x5\x34"+
		"\v\x5\x3\x6\x3\x6\x3\x6\x5\x6\x39\n\x6\x3\x6\x3\x6\x3\x6\x5\x6>\n\x6\x3"+
		"\a\x3\a\x3\a\a\a\x43\n\a\f\a\xE\a\x46\v\a\x3\b\x3\b\x3\b\a\bK\n\b\f\b"+
		"\xE\bN\v\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x5\tW\n\t\x3\n\x3\n\x3\n"+
		"\a\n\\\n\n\f\n\xE\n_\v\n\x3\n\x2\x2\x2\v\x2\x2\x4\x2\x6\x2\b\x2\n\x2\f"+
		"\x2\xE\x2\x10\x2\x12\x2\x2\x2\x64\x2\x1B\x3\x2\x2\x2\x4\x1D\x3\x2\x2\x2"+
		"\x6+\x3\x2\x2\x2\b-\x3\x2\x2\x2\n=\x3\x2\x2\x2\f?\x3\x2\x2\x2\xEG\x3\x2"+
		"\x2\x2\x10V\x3\x2\x2\x2\x12X\x3\x2\x2\x2\x14\x15\x5\x4\x3\x2\x15\x16\x5"+
		"\b\x5\x2\x16\x17\a\x2\x2\x3\x17\x1C\x3\x2\x2\x2\x18\x19\x5\b\x5\x2\x19"+
		"\x1A\a\x2\x2\x3\x1A\x1C\x3\x2\x2\x2\x1B\x14\x3\x2\x2\x2\x1B\x18\x3\x2"+
		"\x2\x2\x1C\x3\x3\x2\x2\x2\x1D\x1E\x5\x6\x4\x2\x1E$\a\x18\x2\x2\x1F \x5"+
		"\x6\x4\x2 !\a\x18\x2\x2!#\x3\x2\x2\x2\"\x1F\x3\x2\x2\x2#&\x3\x2\x2\x2"+
		"$\"\x3\x2\x2\x2$%\x3\x2\x2\x2%\x5\x3\x2\x2\x2&$\x3\x2\x2\x2\'(\a\a\x2"+
		"\x2(,\x5\x12\n\x2)*\a\b\x2\x2*,\x5\x12\n\x2+\'\x3\x2\x2\x2+)\x3\x2\x2"+
		"\x2,\a\x3\x2\x2\x2-\x32\x5\n\x6\x2./\a\x18\x2\x2/\x31\x5\n\x6\x2\x30."+
		"\x3\x2\x2\x2\x31\x34\x3\x2\x2\x2\x32\x30\x3\x2\x2\x2\x32\x33\x3\x2\x2"+
		"\x2\x33\t\x3\x2\x2\x2\x34\x32\x3\x2\x2\x2\x35\x36\a\x31\x2\x2\x36\x39"+
		"\a\x1A\x2\x2\x37\x39\x3\x2\x2\x2\x38\x35\x3\x2\x2\x2\x38\x37\x3\x2\x2"+
		"\x2\x39:\x3\x2\x2\x2:>\x5\f\a\x2;>\x5\f\a\x2<>\x3\x2\x2\x2=\x38\x3\x2"+
		"\x2\x2=;\x3\x2\x2\x2=<\x3\x2\x2\x2>\v\x3\x2\x2\x2?\x44\x5\xE\b\x2@\x41"+
		"\a\x1D\x2\x2\x41\x43\x5\xE\b\x2\x42@\x3\x2\x2\x2\x43\x46\x3\x2\x2\x2\x44"+
		"\x42\x3\x2\x2\x2\x44\x45\x3\x2\x2\x2\x45\r\x3\x2\x2\x2\x46\x44\x3\x2\x2"+
		"\x2GL\x5\x10\t\x2HI\a\x1E\x2\x2IK\x5\x10\t\x2JH\x3\x2\x2\x2KN\x3\x2\x2"+
		"\x2LJ\x3\x2\x2\x2LM\x3\x2\x2\x2M\xF\x3\x2\x2\x2NL\x3\x2\x2\x2OP\a\x1B"+
		"\x2\x2PQ\x5\f\a\x2QR\a\x1C\x2\x2RW\x3\x2\x2\x2SW\a\x31\x2\x2TW\a\x30\x2"+
		"\x2UW\a\x32\x2\x2VO\x3\x2\x2\x2VS\x3\x2\x2\x2VT\x3\x2\x2\x2VU\x3\x2\x2"+
		"\x2W\x11\x3\x2\x2\x2X]\a\x31\x2\x2YZ\a\x19\x2\x2Z\\\a\x31\x2\x2[Y\x3\x2"+
		"\x2\x2\\_\x3\x2\x2\x2][\x3\x2\x2\x2]^\x3\x2\x2\x2^\x13\x3\x2\x2\x2_]\x3"+
		"\x2\x2\x2\f\x1B$+\x32\x38=\x44LV]";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace AnalizadorSintactico
