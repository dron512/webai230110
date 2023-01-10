'''
파이보 프로젝트는 ORM을 지원하는 파이썬 데이터베이스 도구인
SQLAlchemy를 사용한다.
SQLAlchemy는 모델 기반으로 데이터베이스를 처리한다.
지금은 모델 기반으로 데이터베이스를 처리한다는 말이 이해되지
않겠지만, 이후 프로젝트를 진행하면 잘 알 수 있을 것이다.

'''

'''
insert into question (subject, content) values ('안녕하세요', '가입 인사드립니다 ^^');
insert into question (subject, content) values ('질문 있습니다', 'ORM이 궁금합니다');
'''
from pybo import db

class Question(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    subject = db.Column(db.String(200), nullable=False)
    content = db.Column(db.Text(), nullable=False)
    create_date = db.Column(db.DateTime(), nullable=False)

class Answer(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    question_id = db.Column(db.Integer, db.ForeignKey('question.id', ondelete='CASCADE'))
    question = db.relationship('Question', backref=db.backref('answer_set'))
    content = db.Column(db.Text(), nullable=False)
    create_date = db.Column(db.DateTime(), nullable=False)
    
# question1 = Question(subject=’안녕하세요’, content='가입 인사드립니다 ^^')
# db.session.add(question1)
# question2 = Question(subject=’질문 있습니다’, content='ORM이 궁금합니다')
# db.session.add(question2)