import pytest

from calculator_logic import add, subtract, multiply, divide


@pytest.mark.parametrize(
    "a,b,expected",
    [
        (1, 1, 2),
        (-2, 3, 1),
        (0, 0, 0),
    ],
)
def test_add_cases(a, b, expected):
    assert add(a, b) == expected


def test_subtract_negative_result():
    assert subtract(5, 8) == -3


def test_multiply_zero():
    assert multiply(10, 0) == 0


def test_divide_fraction():
    assert divide(1, 2) == 0.5


def test_divide_by_zero_returns_error_message():
    assert divide(7, 0) == "Error: division by zero"


def test_intentional_failure():
    assert add(2, 2) == 4
