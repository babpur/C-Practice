﻿// c# 자료형


// 정수형

sbyte sb = 1;
// 부호가 있는 8비트 정수 

byte b = 1;
// 부호가 없는 8비트 정수

short s = 1;
// 부호가 있는 16비트 정수

ushort us = 1;
// 부호가 없는 16비트 정수

int i = 1;
// 부호가 있는 32비트 정수

uint ui = 1;
// 부호가 없는 32비트 정수

long l = 1L;
// 부호가 있는 64비트 정수
// suffix로 L을 붙인다.

ulong ul = 1L;
// 부호가 없는 64비트 정수

// ------------------------------

// 실수형

float f = 3.141592f;
// 32비트 == 4byte
// suffix로 f를 붙인다.
// 값을 반올림하여 소수점 6자리까지 표현

double d = 3.141592;
// suffix d는 생략 가능하다.
// 값을 반올림하여 소수점 14자리까지 표현

decimal dec = 3.14159221318957931487123m;
// decimal의 suffix는 d가 아닌 m이다.
// 값을 버리며 소수점 28자리까지 표현

// ------------------------------

// 문자형
char cType = 'A';
// 유니코드 문자 2btye == 16bit
// 작은따옴표를 사용

string stringType = "스트링";
// 유니코드 문자열
// 큰따옴표를 사용


// ------------------------------


// 논리형
bool tOrF = true;
// 8비트 == 1byte
// 참 or 거짓의 값만 갖는다.