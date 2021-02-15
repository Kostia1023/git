import datetime


class Audio_file:
    def __init__(self, _format, _date, _duration, _frequency, _deep):
        self.format = _format
        self.date = _date
        self.duration = _duration
        self.frequency = _frequency
        self.deep = _deep

    def age(self):
        now = datetime.datetime.today()
        delta = now - self.date
        return delta

    def points_of_save(self):
        return self.frequency * self.duration

    def size_file(self):
        return self.deep * self.duration


