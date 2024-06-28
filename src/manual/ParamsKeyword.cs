// To define a method parameter that takes a variable number of arguments.
static double CheckOut(params double[] prices)
{
    double total = 0;
    foreache (double price in prices)
    {
        total += price;
    }
    return total;
}

// Valid.
CheckOut(1)
// Valid too.
CheckOut(1, 2, 3);