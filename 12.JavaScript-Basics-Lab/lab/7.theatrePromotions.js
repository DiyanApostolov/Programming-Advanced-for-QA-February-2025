function theatrePromotions(dayType, age) {
    let price;
    
    // Check for invalid age
    // age < 0 or age > 122 --> Age is not within the acceptable range. Print error and exit.
    if (age < 0 || age > 122) {
        console.log('Error!');
        return; // Exit the function early if age is invalid
    }

    // Age is between 0 and 18 (inclusive)
    // Nested if statements to determine the price based on dayType
    if (age >= 0 && age <= 18) {
        // Day type is Weekday
        if (dayType === 'Weekday') {
            price = 12.00;
        // Day type is Weekend
        } else if (dayType === 'Weekend') {
            price = 15.00;
        // Day type is Holiday
        } else if (dayType === 'Holiday') {
            price = 5.00;
        }
    // Age is between 19 and 64 (inclusive)
    // Nested if statements to determine the price based on dayType
    } else if (age > 18 && age <= 64) {
        // Day type is Weekday
        if (dayType === 'Weekday') {
            price = 18.00;
        // Day type is Weekend
        } else if (dayType === 'Weekend') {
            price = 20.00;
        // Day type is Holiday
        } else if (dayType === 'Holiday') {
            price = 12.00;
        }
    // Age is between 65 and 122 (inclusive)
    // Nested if statements to determine the price based on dayType
    } else if (age > 64 && age <= 122) {
        // Day type is Weekday
        if (dayType === 'Weekday') {
            price = 12.00;
        // Day type is Weekend
        } else if (dayType === 'Weekend') {
            price = 15.00;
        // Day type is Holiday
        } else if (dayType === 'Holiday') {
            price = 10.00;
        }
    }

    // Print the determined price followed by a $ sign
    console.log(`${price}$`);
}


theatrePromotions('Weekday', 5);    // Expected output: "12$"
theatrePromotions('Weekend', 27);   // Expected output: "20$"
theatrePromotions('Holiday', 70);   // Expected output: "10$"
theatrePromotions('Weekday', -5);   // Expected output: "Error!"
theatrePromotions('Holiday', 150);  // Expected output: "Error!"
