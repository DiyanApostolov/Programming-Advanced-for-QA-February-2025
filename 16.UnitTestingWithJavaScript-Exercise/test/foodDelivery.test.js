import { foodDelivery } from '../06-FoodDelivery/food delivery.js'
import { expect } from 'chai'

describe('Test_foodDelivery', () => {

    describe('getCategory', () => {
        it('should return correct message for category', () => {
            expect(foodDelivery.getCategory("Vegan")).to.equal("Dishes that contain no animal products.");
            expect(foodDelivery.getCategory("Vegetarian")).to.equal("Dishes that contain no meat or fish.");
            expect(foodDelivery.getCategory("Gluten-Free")).to.equal("Dishes that contain no gluten.");
            expect(foodDelivery.getCategory("All")).to.equal("All available dishes.");
        });

        it('should throw error incorrect category', () => {
            expect(() => foodDelivery.getCategory(123)).to.throw("Invalid Category!");
            expect(() => foodDelivery.getCategory("No category")).to.throw("Invalid Category!");
            expect(() => foodDelivery.getCategory([])).to.throw("Invalid Category!");
            expect(() => foodDelivery.getCategory({})).to.throw("Invalid Category!");
        });
    });

    describe('addMenuItem', () => {
        it('should throw error invalid input', () => {
            expect(() => foodDelivery.addMenuItem(123, 10)).to.throw("Invalid Information!");
            expect(() => foodDelivery.addMenuItem([1, 2, 3], "price")).to.throw("Invalid Information!");
            expect(() => foodDelivery.addMenuItem([1, 2, 3], 4.99)).to.throw("Invalid Information!");
            expect(() => foodDelivery.addMenuItem([], 100)).to.throw("Invalid Information!");
        });
        it('should return correct message', () => {
            expect(foodDelivery.addMenuItem([{name: "Food1", price: 10},
                                             {name: "Food2", price: 20},
                                             {name: "Food3", price: 30}], 100)).to.equal("There are 3 available menu items matching your criteria!");
            expect(foodDelivery.addMenuItem([{name: "Food1", price: 10},
                                            {name: "Food2", price: 20},
                                            {name: "Food3", price: 30}], 20)).to.equal("There are 2 available menu items matching your criteria!");
        });
    });

    describe('calculateOrderCost', () => { //calculateOrderCost(shipping-[], addons-[], discount-bool)
        it('should throw error invalid input', () => {
            expect(() => foodDelivery.calculateOrderCost()).to.throw("Invalid Information!");
            expect(() => foodDelivery.calculateOrderCost([1, 2, 3], "price", true)).to.throw("Invalid Information!");
            expect(() => foodDelivery.calculateOrderCost([1, 2, 3], [1, 2, 3], 3.14)).to.throw("Invalid Information!");
            expect(() => foodDelivery.calculateOrderCost(42, [1, 2, 3], false)).to.throw("Invalid Information!");
        });

        it('should return correct message', () => {
            expect(foodDelivery.calculateOrderCost(['standard', 'express'], ['sauce', 'beverage'], false))
            .to.equal('You spend $12.50 for shipping and addons!')
        });
        it('should return correct message', () => {
            expect(foodDelivery.calculateOrderCost(['standard', 'express'], ['sauce', 'beverage'], true))
            .to.equal('You spend $10.63 for shipping and addons with a 15% discount!')
        });
    });
});