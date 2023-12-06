# Day 6

# Example
# Time:      7  15   30
# Distance:  9  40  200
# Solution:  4   8    9 -> 288 ways

# Time:        41     66     72     66
# Distance:   244   1047   1228   1040

ex = [(7,9), (15,40), (30,200)]
mine = [(41,244), (66,1047), (72,1228), (66,1040)]

def calc_distance(t_total: int, t_press: int) -> int:
    # velocity * time
    return t_press * (t_total - t_press)

def return_winners(race_series: tuple[int,int]) -> list[int]:
    win_totals = []
    for t_race, d_race in race_series:
        win_count = 0
        for t_press in range(1, t_race):
            if calc_distance(t_race, t_press) > d_race:
                win_count += 1
        win_totals.append(win_count)
    return win_totals

wins = return_winners(mine)
result = 1
for win in wins:
    print(win)
    result = win * result
print(result)