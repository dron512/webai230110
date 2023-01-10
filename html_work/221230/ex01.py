# from gtts import gTTS

# tts = gTTS(text='안녕하세요',lang='ko')
# tts.save('hi_ko.mp3')

# tts = gTTS(text='날씨데이터를 불러왔습니다.',lang='ko')
# tts.save('hi_weather.mp3')

import playsound
import multiprocessing

play1 = multiprocessing.Process(target=playsound.playsound('hi_ko.mp3'))
play1.start()
play1.terminate()

play2 = multiprocessing.Process(target=playsound.playsound('hi_weather.mp3'))
play2.start()





