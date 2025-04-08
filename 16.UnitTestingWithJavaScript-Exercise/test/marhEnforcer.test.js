import { mathEnforcer } from '../03-MathEnforcer/mathEnforcer.js'
import { assert } from 'chai'

describe('Test_mathEnforcer', () => {
    describe('Test_addFive', () => {
        it('shoud return undefined if parameter is not a number', () => {
            assert.isUndefined(mathEnforcer.addFive('a'));
            assert.isUndefined(mathEnforcer.addFive('5'));
            assert.isUndefined(mathEnforcer.addFive(null));
            assert.isUndefined(mathEnforcer.addFive(undefined));
        });
        it('shoud return result plus 5', () => {
            assert.equal(mathEnforcer.addFive(5), 10);
            assert.equal(mathEnforcer.addFive(-15), -10);
            assert.closeTo(mathEnforcer.addFive(3.52), 8.52, 0.001)
        });
    });
    describe('Test_subtractTen', () => {
        it('shoud return undefined if parameter is not a number', () => {
            assert.isUndefined(mathEnforcer.subtractTen('a'));
            assert.isUndefined(mathEnforcer.subtractTen('5'));
            assert.isUndefined(mathEnforcer.subtractTen(null));
            assert.isUndefined(mathEnforcer.subtractTen(undefined));
        });
        it('shoud return result minus ten', () => {
            assert.equal(mathEnforcer.subtractTen(100), 90);
            assert.equal(mathEnforcer.subtractTen(-10), -20);
            assert.closeTo(mathEnforcer.subtractTen(50.65), 40.65, 0.001)
        });
    });
    describe('Test_sum', () => {
        it('shoud return undefined if first parameter is not a number', () => {
            assert.isUndefined(mathEnforcer.sum('a', 5))
            assert.isUndefined(mathEnforcer.sum('5', 5))
            assert.isUndefined(mathEnforcer.sum(null, 5))
            assert.isUndefined(mathEnforcer.sum(undefined, 5))
        });
        it('shoud return undefined if second parameter is not a number', () => {
            assert.isUndefined(mathEnforcer.sum(5, 'a'))
            assert.isUndefined(mathEnforcer.sum(5, '5'))
            assert.isUndefined(mathEnforcer.sum(5, null))
            assert.isUndefined(mathEnforcer.sum(5, undefined))
        });
        it('shoud return the sum ot the two parameters if they are valid numbers', () => {
            assert.equal(mathEnforcer.sum(5, 10), 15)
            assert.equal(mathEnforcer.sum(-5, 10), 5)
            assert.equal(mathEnforcer.sum(-5, -10), -15)
            assert.closeTo(mathEnforcer.sum(2.45, 3.26), 5.71, 0.001)
        });
    });
});