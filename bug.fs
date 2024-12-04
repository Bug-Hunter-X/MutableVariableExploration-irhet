let mutable x = 1
let mutable y = 2
let z = x + y
printf "%d\n" z
x <- 3
printf "%d\n" z // z is still 3, not 5 because it was calculated with the initial values of x and y