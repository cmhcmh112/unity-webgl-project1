# Nginx를 기반 이미지로 사용
FROM nginx:alpine

# Nginx 설정 파일 복사
COPY nginx.conf /etc/nginx/conf.d/default.conf

# Unity WebGL 빌드 파일 복사
COPY builds/WebGL /usr/share/nginx/html

# 컨테이너에서 사용할 포트 설정
EXPOSE 8080
