class Radio:
    def __init__(self, station, volume, on):
        self.station = station
        self.volume = volume
        self.on = on

    def getStation(self):
        return self.station

    def getVolume(self):
        return self.volume

    def turnOn(self):
        self.on = 'on'
        return self.on

    def turnOff(self):
        self.on = 'off'
        return self.on

    def stationUp(self, clicks):
        if self.on == 'on':
            self.station += clicks
            return self.station
        else:
            return 'The radio is off'

    def stationDown(self, clicks):
        if self.on == 'on':
            self.station -= clicks
            return self.station
        else:
            return 'The radio is off'

    def volumeUp(self, clicks):
        if self.on == 'on':
            self.volume += clicks
        else:
            return 'The radio is off'

    def volumeDown(self, clicks):
        if self.on == 'on':
            self.volume -= clicks
        else:
            return 'The radio is off'

    def toString(self):
        if self.on == 'on':
            return f'The radio station is {self.getStation()} and the volume level is {self.getVolume()}.'
        else:
            return 'The radio is off.'


def main():
    radio = Radio(1, 1, 'off')
    print(f'Turn radio {radio.turnOn()}:')
    print(f'\tThe radio station is {radio.getStation()} and the volume level is {radio.getVolume()}.')
    print()
    print('Turn volume up by 3:')
    radio.volumeUp(3)
    print(f'\tThe radio station is {radio.getStation()} and the volume level is {radio.getVolume()}.')
    print()
    print('Move station up by 5:')
    radio.stationUp(5)
    print(f'\tThe radio station is {radio.getStation()} and the volume level is {radio.getVolume()}.')
    print()
    print('Turn volume down by 1:')
    radio.volumeDown(1)
    print(f'\tThe radio station is {radio.getStation()} and the volume level is {radio.getVolume()}.')
    print()
    print('Move station up by 3:')
    radio.stationUp(3)
    print(f'\tThe radio station is {radio.getStation()} and the volume level is {radio.getVolume()}.')
    print()
    print('Turn radio off.')
    print(f'\t The radio is {radio.turnOff()}.')
    print()
    print('Turn volume up by 2:')
    print(f'\t{radio.volumeUp(2)}.')
    print()
    print('Turn station down by 2:')
    print(f'\t{radio.stationDown(2)}.')

main()
