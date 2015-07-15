Public Interface IPromoData
	Property DataAddedToHash As Boolean
	Sub PrepareData(ByRef promoDataHash As Hashtable)
	Sub ToPromoStepList(ByVal stepName As TSWizards.BaseInteriorStep, _
						ByRef promoStepList As ArrayList)
End Interface
