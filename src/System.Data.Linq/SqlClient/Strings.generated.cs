namespace System.Data.Linq.SqlClient
{
  internal static class Strings
  {
    internal static string VbLikeDoesNotSupportMultipleCharacterRanges
    {
      get => SR.GetString(nameof (VbLikeDoesNotSupportMultipleCharacterRanges));
    }

    internal static string VbLikeUnclosedBracket => SR.GetString(nameof (VbLikeUnclosedBracket));

    internal static string ProviderCannotBeUsedAfterDispose
    {
      get => SR.GetString(nameof (ProviderCannotBeUsedAfterDispose));
    }

    internal static string ArgumentTypeMismatch(object p0)
    {
      return SR.GetString(nameof (ArgumentTypeMismatch), p0);
    }

    internal static string ContextNotInitialized => SR.GetString(nameof (ContextNotInitialized));

    internal static string CouldNotDetermineSqlType(object p0)
    {
      return SR.GetString(nameof (CouldNotDetermineSqlType), p0);
    }

    internal static string CouldNotDetermineDbGeneratedSqlType(object p0)
    {
      return SR.GetString(nameof (CouldNotDetermineDbGeneratedSqlType), p0);
    }

    internal static string CouldNotDetermineCatalogName
    {
      get => SR.GetString(nameof (CouldNotDetermineCatalogName));
    }

    internal static string CreateDatabaseFailedBecauseOfClassWithNoMembers(object p0)
    {
      return SR.GetString(nameof (CreateDatabaseFailedBecauseOfClassWithNoMembers), p0);
    }

    internal static string CreateDatabaseFailedBecauseOfContextWithNoTables(object p0)
    {
      return SR.GetString(nameof (CreateDatabaseFailedBecauseOfContextWithNoTables), p0);
    }

    internal static string CreateDatabaseFailedBecauseSqlCEDatabaseAlreadyExists(object p0)
    {
      return SR.GetString(nameof (CreateDatabaseFailedBecauseSqlCEDatabaseAlreadyExists), p0);
    }

    internal static string InvalidConnectionArgument(object p0)
    {
      return SR.GetString(nameof (InvalidConnectionArgument), p0);
    }

    internal static string CannotEnumerateResultsMoreThanOnce
    {
      get => SR.GetString(nameof (CannotEnumerateResultsMoreThanOnce));
    }

    internal static string IifReturnTypesMustBeEqual(object p0, object p1)
    {
      return SR.GetString(nameof (IifReturnTypesMustBeEqual), p0, p1);
    }

    internal static string ToStringOnlySupportedForPrimitiveTypes
    {
      get => SR.GetString(nameof (ToStringOnlySupportedForPrimitiveTypes));
    }

    internal static string TransactionDoesNotMatchConnection
    {
      get => SR.GetString(nameof (TransactionDoesNotMatchConnection));
    }

    internal static string UnexpectedTypeCode(object p0)
    {
      return SR.GetString(nameof (UnexpectedTypeCode), p0);
    }

    internal static string UnsupportedDateTimeConstructorForm
    {
      get => SR.GetString(nameof (UnsupportedDateTimeConstructorForm));
    }

    internal static string UnsupportedDateTimeOffsetConstructorForm
    {
      get => SR.GetString(nameof (UnsupportedDateTimeOffsetConstructorForm));
    }

    internal static string UnsupportedStringConstructorForm
    {
      get => SR.GetString(nameof (UnsupportedStringConstructorForm));
    }

    internal static string UnsupportedTimeSpanConstructorForm
    {
      get => SR.GetString(nameof (UnsupportedTimeSpanConstructorForm));
    }

    internal static string MemberCannotBeTranslated(object p0, object p1)
    {
      return SR.GetString(nameof (MemberCannotBeTranslated), p0, p1);
    }

    internal static string NonConstantExpressionsNotSupportedFor(object p0)
    {
      return SR.GetString(nameof (NonConstantExpressionsNotSupportedFor), p0);
    }

    internal static string MathRoundNotSupported => SR.GetString(nameof (MathRoundNotSupported));

    internal static string SqlMethodOnlyForSql(object p0)
    {
      return SR.GetString(nameof (SqlMethodOnlyForSql), p0);
    }

    internal static string NonConstantExpressionsNotSupportedForRounding
    {
      get => SR.GetString(nameof (NonConstantExpressionsNotSupportedForRounding));
    }

    internal static string CompiledQueryAgainstMultipleShapesNotSupported
    {
      get => SR.GetString(nameof (CompiledQueryAgainstMultipleShapesNotSupported));
    }

    internal static string IndexOfWithStringComparisonArgNotSupported
    {
      get => SR.GetString(nameof (IndexOfWithStringComparisonArgNotSupported));
    }

    internal static string LastIndexOfWithStringComparisonArgNotSupported
    {
      get => SR.GetString(nameof (LastIndexOfWithStringComparisonArgNotSupported));
    }

    internal static string ConvertToCharFromBoolNotSupported
    {
      get => SR.GetString(nameof (ConvertToCharFromBoolNotSupported));
    }

    internal static string ConvertToDateTimeOnlyForDateTimeOrString
    {
      get => SR.GetString(nameof (ConvertToDateTimeOnlyForDateTimeOrString));
    }

    internal static string SkipRequiresSingleTableQueryWithPKs
    {
      get => SR.GetString(nameof (SkipRequiresSingleTableQueryWithPKs));
    }

    internal static string NoMethodInTypeMatchingArguments(object p0)
    {
      return SR.GetString(nameof (NoMethodInTypeMatchingArguments), p0);
    }

    internal static string CannotConvertToEntityRef(object p0)
    {
      return SR.GetString(nameof (CannotConvertToEntityRef), p0);
    }

    internal static string ExpressionNotDeferredQuerySource
    {
      get => SR.GetString(nameof (ExpressionNotDeferredQuerySource));
    }

    internal static string DeferredMemberWrongType
    {
      get => SR.GetString(nameof (DeferredMemberWrongType));
    }

    internal static string ArgumentWrongType(object p0, object p1, object p2)
    {
      return SR.GetString(nameof (ArgumentWrongType), p0, p1, p2);
    }

    internal static string ArgumentWrongValue(object p0)
    {
      return SR.GetString(nameof (ArgumentWrongValue), p0);
    }

    internal static string BadProjectionInSelect => SR.GetString(nameof (BadProjectionInSelect));

    internal static string InvalidReturnFromSproc(object p0)
    {
      return SR.GetString(nameof (InvalidReturnFromSproc), p0);
    }

    internal static string WrongDataContext => SR.GetString(nameof (WrongDataContext));

    internal static string BinaryOperatorNotRecognized(object p0)
    {
      return SR.GetString(nameof (BinaryOperatorNotRecognized), p0);
    }

    internal static string CannotAggregateType(object p0)
    {
      return SR.GetString(nameof (CannotAggregateType), p0);
    }

    internal static string CannotCompareItemsAssociatedWithDifferentTable
    {
      get => SR.GetString(nameof (CannotCompareItemsAssociatedWithDifferentTable));
    }

    internal static string ClassLiteralsNotAllowed(object p0)
    {
      return SR.GetString(nameof (ClassLiteralsNotAllowed), p0);
    }

    internal static string ColumnCannotReferToItself
    {
      get => SR.GetString(nameof (ColumnCannotReferToItself));
    }

    internal static string ColumnClrTypeDoesNotAgreeWithExpressionsClrType
    {
      get => SR.GetString(nameof (ColumnClrTypeDoesNotAgreeWithExpressionsClrType));
    }

    internal static string ColumnIsDefinedInMultiplePlaces(object p0)
    {
      return SR.GetString(nameof (ColumnIsDefinedInMultiplePlaces), p0);
    }

    internal static string ColumnIsNotAccessibleThroughGroupBy(object p0)
    {
      return SR.GetString(nameof (ColumnIsNotAccessibleThroughGroupBy), p0);
    }

    internal static string ColumnIsNotAccessibleThroughDistinct(object p0)
    {
      return SR.GetString(nameof (ColumnIsNotAccessibleThroughDistinct), p0);
    }

    internal static string ColumnReferencedIsNotInScope(object p0)
    {
      return SR.GetString(nameof (ColumnReferencedIsNotInScope), p0);
    }

    internal static string ConstructedArraysNotSupported
    {
      get => SR.GetString(nameof (ConstructedArraysNotSupported));
    }

    internal static string ParametersCannotBeSequences
    {
      get => SR.GetString(nameof (ParametersCannotBeSequences));
    }

    internal static string CapturedValuesCannotBeSequences
    {
      get => SR.GetString(nameof (CapturedValuesCannotBeSequences));
    }

    internal static string IQueryableCannotReturnSelfReferencingConstantExpression
    {
      get => SR.GetString(nameof (IQueryableCannotReturnSelfReferencingConstantExpression));
    }

    internal static string CouldNotTranslateExpressionForReading(object p0)
    {
      return SR.GetString(nameof (CouldNotTranslateExpressionForReading), p0);
    }

    internal static string CouldNotGetClrType => SR.GetString(nameof (CouldNotGetClrType));

    internal static string CouldNotGetSqlType => SR.GetString(nameof (CouldNotGetSqlType));

    internal static string CouldNotHandleAliasRef(object p0)
    {
      return SR.GetString(nameof (CouldNotHandleAliasRef), p0);
    }

    internal static string DidNotExpectAs(object p0) => SR.GetString(nameof (DidNotExpectAs), p0);

    internal static string DidNotExpectTypeBinding
    {
      get => SR.GetString(nameof (DidNotExpectTypeBinding));
    }

    internal static string DidNotExpectTypeChange(object p0, object p1)
    {
      return SR.GetString(nameof (DidNotExpectTypeChange), p0, p1);
    }

    internal static string EmptyCaseNotSupported => SR.GetString(nameof (EmptyCaseNotSupported));

    internal static string ExpectedBitFoundPredicate
    {
      get => SR.GetString(nameof (ExpectedBitFoundPredicate));
    }

    internal static string ExpectedClrTypesToAgree(object p0, object p1)
    {
      return SR.GetString(nameof (ExpectedClrTypesToAgree), p0, p1);
    }

    internal static string ExpectedPredicateFoundBit
    {
      get => SR.GetString(nameof (ExpectedPredicateFoundBit));
    }

    internal static string InvalidGroupByExpressionType(object p0)
    {
      return SR.GetString(nameof (InvalidGroupByExpressionType), p0);
    }

    internal static string InvalidGroupByExpression
    {
      get => SR.GetString(nameof (InvalidGroupByExpression));
    }

    internal static string InvalidOrderByExpression(object p0)
    {
      return SR.GetString(nameof (InvalidOrderByExpression), p0);
    }

    internal static string InvalidFormatNode(object p0)
    {
      return SR.GetString(nameof (InvalidFormatNode), p0);
    }

    internal static string InvalidReferenceToRemovedAliasDuringDeflation
    {
      get => SR.GetString(nameof (InvalidReferenceToRemovedAliasDuringDeflation));
    }

    internal static string InvalidSequenceOperatorCall(object p0)
    {
      return SR.GetString(nameof (InvalidSequenceOperatorCall), p0);
    }

    internal static string ParameterNotInScope(object p0)
    {
      return SR.GetString(nameof (ParameterNotInScope), p0);
    }

    internal static string MemberAccessIllegal(object p0, object p1, object p2)
    {
      return SR.GetString(nameof (MemberAccessIllegal), p0, p1, p2);
    }

    internal static string MemberNotPartOfProjection(object p0, object p1)
    {
      return SR.GetString(nameof (MemberNotPartOfProjection), p0, p1);
    }

    internal static string MethodHasNoSupportConversionToSql(object p0)
    {
      return $"Method '{p0}' has no supported translation to SQL.";
    }

    internal static string MethodFormHasNoSupportConversionToSql(object p0, object p1)
    {
      return SR.GetString(nameof (MethodFormHasNoSupportConversionToSql), p0, p1);
    }

    internal static string QueryOperatorNotSupported(object p0)
    {
      return SR.GetString(nameof (QueryOperatorNotSupported), p0);
    }

    internal static string QueryOperatorOverloadNotSupported(object p0)
    {
      return SR.GetString(nameof (QueryOperatorOverloadNotSupported), p0);
    }

    internal static string RequiredColumnDoesNotExist(object p0)
    {
      return SR.GetString(nameof (RequiredColumnDoesNotExist), p0);
    }

    internal static string TypeBinaryOperatorNotRecognized
    {
      get => SR.GetString(nameof (TypeBinaryOperatorNotRecognized));
    }

    internal static string UnexpectedNode(object p0) => SR.GetString(nameof (UnexpectedNode), p0);

    internal static string UnexpectedFloatingColumn
    {
      get => SR.GetString(nameof (UnexpectedFloatingColumn));
    }

    internal static string UnexpectedSharedExpression
    {
      get => SR.GetString(nameof (UnexpectedSharedExpression));
    }

    internal static string UnexpectedSharedExpressionReference
    {
      get => SR.GetString(nameof (UnexpectedSharedExpressionReference));
    }

    internal static string UnhandledBindingType(object p0)
    {
      return SR.GetString(nameof (UnhandledBindingType), p0);
    }

    internal static string UnhandledStringTypeComparison
    {
      get => SR.GetString(nameof (UnhandledStringTypeComparison));
    }

    internal static string UnmappedDataMember(object p0, object p1, object p2)
    {
      return SR.GetString(nameof (UnmappedDataMember), p0, p1, p2);
    }

    internal static string UnrecognizedExpressionNode(object p0)
    {
      return SR.GetString(nameof (UnrecognizedExpressionNode), p0);
    }

    internal static string ValueHasNoLiteralInSql(object p0)
    {
      return SR.GetString(nameof (ValueHasNoLiteralInSql), p0);
    }

    internal static string UnionIncompatibleConstruction
    {
      get => SR.GetString(nameof (UnionIncompatibleConstruction));
    }

    internal static string UnionDifferentMembers => SR.GetString(nameof (UnionDifferentMembers));

    internal static string UnionDifferentMemberOrder
    {
      get => SR.GetString(nameof (UnionDifferentMemberOrder));
    }

    internal static string UnionOfIncompatibleDynamicTypes
    {
      get => SR.GetString(nameof (UnionOfIncompatibleDynamicTypes));
    }

    internal static string UnionWithHierarchy => SR.GetString(nameof (UnionWithHierarchy));

    internal static string UnhandledExpressionType(object p0)
    {
      return SR.GetString(nameof (UnhandledExpressionType), p0);
    }

    internal static string IntersectNotSupportedForHierarchicalTypes
    {
      get => SR.GetString(nameof (IntersectNotSupportedForHierarchicalTypes));
    }

    internal static string ExceptNotSupportedForHierarchicalTypes
    {
      get => SR.GetString(nameof (ExceptNotSupportedForHierarchicalTypes));
    }

    internal static string NonCountAggregateFunctionsAreNotValidOnProjections(object p0)
    {
      return SR.GetString(nameof (NonCountAggregateFunctionsAreNotValidOnProjections), p0);
    }

    internal static string GroupingNotSupportedAsOrderCriterion
    {
      get => SR.GetString(nameof (GroupingNotSupportedAsOrderCriterion));
    }

    internal static string SelectManyDoesNotSupportStrings
    {
      get => SR.GetString(nameof (SelectManyDoesNotSupportStrings));
    }

    internal static string SequenceOperatorsNotSupportedForType(object p0)
    {
      return SR.GetString(nameof (SequenceOperatorsNotSupportedForType), p0);
    }

    internal static string SkipNotSupportedForSequenceTypes
    {
      get => SR.GetString(nameof (SkipNotSupportedForSequenceTypes));
    }

    internal static string ComparisonNotSupportedForType(object p0)
    {
      return SR.GetString(nameof (ComparisonNotSupportedForType), p0);
    }

    internal static string QueryOnLocalCollectionNotSupported
    {
      get => SR.GetString(nameof (QueryOnLocalCollectionNotSupported));
    }

    internal static string UnsupportedNodeType(object p0)
    {
      return SR.GetString(nameof (UnsupportedNodeType), p0);
    }

    internal static string GeneralCollectionMaterializationNotSupported
    {
      get => SR.GetString(nameof (GeneralCollectionMaterializationNotSupported));
    }

    internal static string TypeCannotBeOrdered(object p0)
    {
      return SR.GetString(nameof (TypeCannotBeOrdered), p0);
    }

    internal static string InvalidMethodExecution(object p0)
    {
      return SR.GetString(nameof (InvalidMethodExecution), p0);
    }

    internal static string SprocsCannotBeComposed => SR.GetString(nameof (SprocsCannotBeComposed));

    internal static string InsertItemMustBeConstant
    {
      get => SR.GetString(nameof (InsertItemMustBeConstant));
    }

    internal static string UpdateItemMustBeConstant
    {
      get => SR.GetString(nameof (UpdateItemMustBeConstant));
    }

    internal static string CouldNotConvertToPropertyOrField(object p0)
    {
      return SR.GetString(nameof (CouldNotConvertToPropertyOrField), p0);
    }

    internal static string BadParameterType(object p0)
    {
      return SR.GetString(nameof (BadParameterType), p0);
    }

    internal static string CannotAssignToMember(object p0)
    {
      return SR.GetString(nameof (CannotAssignToMember), p0);
    }

    internal static string MappedTypeMustHaveDefaultConstructor(object p0)
    {
      return SR.GetString(nameof (MappedTypeMustHaveDefaultConstructor), p0);
    }

    internal static string UnsafeStringConversion(object p0, object p1)
    {
      return SR.GetString(nameof (UnsafeStringConversion), p0, p1);
    }

    internal static string CannotAssignNull(object p0)
    {
      return SR.GetString(nameof (CannotAssignNull), p0);
    }

    internal static string ProviderNotInstalled(object p0, object p1)
    {
      return SR.GetString(nameof (ProviderNotInstalled), p0, p1);
    }

    internal static string InvalidProviderType(object p0)
    {
      return SR.GetString(nameof (InvalidProviderType), p0);
    }

    internal static string InvalidDbGeneratedType(object p0)
    {
      return SR.GetString(nameof (InvalidDbGeneratedType), p0);
    }

    internal static string DatabaseDeleteThroughContext
    {
      get => SR.GetString(nameof (DatabaseDeleteThroughContext));
    }

    internal static string CannotMaterializeEntityType(object p0)
    {
      return SR.GetString(nameof (CannotMaterializeEntityType), p0);
    }

    internal static string CannotMaterializeList(object p0)
    {
      return SR.GetString(nameof (CannotMaterializeList), p0);
    }

    internal static string CouldNotConvert(object p0, object p1)
    {
      return SR.GetString(nameof (CouldNotConvert), p0, p1);
    }

    internal static string CannotTranslateExpressionToSql
    {
      get => SR.GetString(nameof (CannotTranslateExpressionToSql));
    }

    internal static string TextNTextAndImageCannotOccurInDistinct(object p0)
    {
      return SR.GetString(nameof (TextNTextAndImageCannotOccurInDistinct), p0);
    }

    internal static string TextNTextAndImageCannotOccurInUnion(object p0)
    {
      return SR.GetString(nameof (TextNTextAndImageCannotOccurInUnion), p0);
    }

    internal static string LenOfTextOrNTextNotSupported(object p0)
    {
      return SR.GetString(nameof (LenOfTextOrNTextNotSupported), p0);
    }

    internal static string LogAttemptingToDeleteDatabase(object p0)
    {
      return SR.GetString(nameof (LogAttemptingToDeleteDatabase), p0);
    }

    internal static string SourceExpressionAnnotation(object p0)
    {
      return $"Source Expression: {p0}";
    }

    internal static string MaxSizeNotSupported(object p0)
    {
      return SR.GetString(nameof (MaxSizeNotSupported), p0);
    }

    internal static string LogGeneralInfoMessage(object p0, object p1)
    {
      return SR.GetString("LenOfTextOrNTextNotSupported", p0, p1);
    }
  }
}
