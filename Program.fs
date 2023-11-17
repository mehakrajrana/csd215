let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]
let addSalaries salary =
    if salary < 49020 then salary + 20000
    else salary

let filteredSalaries = List.filter (fun salary -> salary < 49020) salaries
let addedSalaries = List.map addSalaries filteredSalaries

printfn " Salaries below $49,020: %A" filteredSalaries
printfn "added salary: %A" addedSalaries




let sal = [75000; 48000; 120000; 190000; 300113; 92000; 36000]
let filtersal= sal |> List.filter (fun x -> x >= 50000 && x<= 100000)
let sum = List.fold (fun acc x -> acc + x) 0 filtersal
printfn "Orignal Salary: %A" sal
printfn "Salary between 50000 to 100000: %A" filtersal
printfn "Sum using fold: %d" sum





let additionofMultiplesOf3 m =
    let rec loop acc current =
        if current > m then
            acc
        else
            loop (acc + current) (current + 3)

    loop 0 3

let result = additionofMultiplesOf3 56
printfn "The sum of multiples of 3 up to 56 is: %d" result






let s = [75000; 48000; 120000; 190000; 300113; 92000; 36000]
let mtax=
 List.map (fun sal -> 
   if sal <= 49020 then sal - sal / 100 * 15
   elif sal > 49020 && sal <= 98040 then sal - sal / 100 * 20
   elif sal > 98040 && sal <= 151978 then sal - sal / 100 * 26
   elif sal > 151978 && sal <= 216511 then sal - sal / 100 * 29
   elif sal > 216511 then sal - sal / 100 * 33
   else 0
   ) s
let taxamt = 
  List.map2 (fun x y -> x - y) s  mtax
printfn "actual Salary %A" s
printfn "After Deduction: %A" mtax
printfn "tot tax: %A" taxamt