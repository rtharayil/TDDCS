# -*- coding: utf-8 -*-
import unittest

from h_basket import Item, HamaraBasket


class GildedRoseTest(unittest.TestCase):
    def test_foo(self):
        items = [Item("foo", 0, 0)]
        gilded_rose = HamaraBasket(items)
        gilded_rose.update_quality()
        self.assertEquals("fixme", items[0].name)

        
if __name__ == '__main__':
    unittest.main()