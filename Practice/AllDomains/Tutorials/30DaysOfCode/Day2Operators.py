/*	author:@shivkrthakur  */
mealCost =float(input())
tipPercent = float(input())
taxPercent = float(input())

tip = mealCost * (tipPercent/100)
#print "Tip: ", tip
tax = mealCost * (taxPercent/100)
#print "Tax: ", tax
totalCost = mealCost + tip + tax
#print "TotalCost: ", totalCost
totalCost = int(round(totalCost))
print("The total meal cost is", totalCost,"dollars.")