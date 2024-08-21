# 협업 준비

## Git의 기능
1. Branch를 나눠 작업
2. Commit & Push
3. CheckOut : 과거의 이력으로 돌아가고 로컬저장소를 갱신
4. Reset : 이전커밋으로 돌아가고 최근 작업내역을 삭제

##  Git Flow

### Commit Message
- 커밋 메세지 규칙 준수
- 팀의 상황에 맞게 세부규칙을 합의하에 지정
- [커밋 메세지 규칙](https://velog.io/@chojs28/Git-%EC%BB%A4%EB%B0%8B-%EB%A9%94%EC%8B%9C%EC%A7%80-%EA%B7%9C%EC%B9%99)

### Git Flow

#### Master 
- 최종 결과물을 위한 브랜치 
- Master 브랜치는 그대로 둠

#### Develop
- 실질적인 개발을 위한 브랜치
- develop 분기를 기준으로 분기를 나눔


#### feature 

- 하나의 기능을 개발하기 위한 분기
- develop 분기에서 생성
- 기능개발이 완료되면 develop 분기에 병합 후 삭제

#### Release 
- 배포를 준비하기 위한 분기
- develop 분기에서 생성하며 기능개발이 아닌 오로지 배포를 위한 버그수정만을 진행
- 버그 수정이 있는 경우마다 develop 분기에도 수정사항 적용
- 버그수정과정이 완료된 release 분기는 master 분기에 병합되며 이는 곧 배포를 의미

#### HotFix
- master 분기의 버그를 긴급하게 고치기 위한 분기
- 버그를 발견한 master분기에 생성하며 신속하게 패치하기 위한 작업만을 진행
- 버그수정이 완료된 경우 master 분기와 develop 분기에 수정사항을 적용함